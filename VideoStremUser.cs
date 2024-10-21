using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStreamUserAPI
{
    [Table("VIDEO_STREAM_USER", Schema = "DVR")]
    public class VideoStreamUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("USER_ID")]
        public int UserId { get; set; } // Changed from User_Id to UserId

        [Required]
        [MaxLength(50)]
        [Column("FIRST_NAME")]
        public string FirstName { get; set; } = string.Empty; // Changed from First_Name to FirstName

        [Required]
        [MaxLength(50)]
        [Column("LAST_NAME")]
        public string LastName { get; set; } = string.Empty; // Changed from Last_Name to LastName

        [Required]
        [MaxLength(20)]
        [Column("BADGE_NUMBER")] // Specify database column name
        public string? BadgeNumber { get; set; } = string.Empty; // Changed from Badge_Number to BadgeNumber

        [Required]
        [MaxLength(30)]
        [Column("USER_ROLE")] // Specify database column name
        public string UserRole { get; set; } = string.Empty; // Changed from User_Role to UserRole

        [MaxLength(50)]
        [Column("LOCATION")] // Make sure it matches exactly as in the database (case-sensitive)
        public string? Location { get; set; }


        [DataType(DataType.Date)]
        [Column("ACCESS_CREATED_DATE")] // Specify database column name
        public DateTime AccessCreatedDate { get; set; } = DateTime.Now; // Changed from Access_Created_Date to AccessCreatedDate

        [Required]
        [MaxLength(1)]
        [Column("IS_AUTHORIZED")] // Specify database column name
        public string IsAuthorized { get; set; } = "N"; // Changed from Is_Authorized to IsAuthorized

        [NotMapped]
        [Column("AUTHORIZED_NOT_AUTHORIZED")]
        public string AuthorizedNotAuthorized => IsAuthorized == "Y" ? "Authorized" : "Not Authorized";
    }

}
