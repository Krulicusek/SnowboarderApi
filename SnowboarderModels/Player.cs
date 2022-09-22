using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SnowboarderModels
{
    [Table("Player")]
   
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }
    }
}
