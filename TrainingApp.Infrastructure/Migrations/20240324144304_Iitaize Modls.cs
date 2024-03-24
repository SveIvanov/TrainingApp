using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingApp.Infrastructure.Migrations
{
    public partial class IitaizeModls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardioTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    DistanceInMeters = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardioTrainings_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Cardio Training");

            migrationBuilder.CreateTable(
                name: "Crossfits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crossfits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crossfits_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Crossfit training");

            migrationBuilder.CreateTable(
                name: "Hiits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    Intervals = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hiits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hiits_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "HIIT Training");

            migrationBuilder.CreateTable(
                name: "StrenghtTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyPart = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrenghtTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StrenghtTrainings_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Strenght Training");

            migrationBuilder.CreateTable(
                name: "CardioTrainingsParticipants",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardioTrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioTrainingsParticipants", x => new { x.CardioTrainingId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_CardioTrainingsParticipants_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CardioTrainingsParticipants_CardioTrainings_CardioTrainingId",
                        column: x => x.CardioTrainingId,
                        principalTable: "CardioTrainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CrossfitsParticipants",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CrossfitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrossfitsParticipants", x => new { x.CrossfitId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_CrossfitsParticipants_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CrossfitsParticipants_Crossfits_CrossfitId",
                        column: x => x.CrossfitId,
                        principalTable: "Crossfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HiitsParticipants",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HiitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiitsParticipants", x => new { x.HiitId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_HiitsParticipants_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HiitsParticipants_Hiits_HiitId",
                        column: x => x.HiitId,
                        principalTable: "Hiits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StrenghtTrainingsParticipants",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StrenghtTrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrenghtTrainingsParticipants", x => new { x.StrenghtTrainingId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_StrenghtTrainingsParticipants_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StrenghtTrainingsParticipants_StrenghtTrainings_StrenghtTrainingId",
                        column: x => x.StrenghtTrainingId,
                        principalTable: "StrenghtTrainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardioTrainings_TrainerId",
                table: "CardioTrainings",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CardioTrainingsParticipants_ParticipantId",
                table: "CardioTrainingsParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Crossfits_TrainerId",
                table: "Crossfits",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CrossfitsParticipants_ParticipantId",
                table: "CrossfitsParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Hiits_TrainerId",
                table: "Hiits",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_HiitsParticipants_ParticipantId",
                table: "HiitsParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_StrenghtTrainings_TrainerId",
                table: "StrenghtTrainings",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_StrenghtTrainingsParticipants_ParticipantId",
                table: "StrenghtTrainingsParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardioTrainingsParticipants");

            migrationBuilder.DropTable(
                name: "CrossfitsParticipants");

            migrationBuilder.DropTable(
                name: "HiitsParticipants");

            migrationBuilder.DropTable(
                name: "StrenghtTrainingsParticipants");

            migrationBuilder.DropTable(
                name: "CardioTrainings");

            migrationBuilder.DropTable(
                name: "Crossfits");

            migrationBuilder.DropTable(
                name: "Hiits");

            migrationBuilder.DropTable(
                name: "StrenghtTrainings");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
