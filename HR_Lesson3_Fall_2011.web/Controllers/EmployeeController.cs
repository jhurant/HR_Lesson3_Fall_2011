using HR_Lesson3_Fall_2011.web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR_Lesson3_Fall_2011.web.Controllers
{
    public class EmployeeController : Controller
    {

        List<Employee> employees = new List<Employee> { 
            new Employee{
                Id = 5,
                Name = "Moe",
                DateHired = DateTime.Now.AddYears(-3),
                Bio = "Moses Harry Horwitz (June 19, 1897 – May 4, 1975), known professionally as Moe Howard, was an American actor and comedian best known as the leader of The Three Stooges, the farce comedy team who starred in motion pictures and television for four decades. His distinctive hairstyle came about when he was a boy and cut off his curls with a pair of scissors, producing a ragged shape approximating a bowl cut."
            },
            new Employee{
              Id = 9,
              Name = "Larry",
              DateHired = DateTime.Now.AddYears(-1),
              Bio = "Fine was born to a Jewish family as Louis Feinberg[2] at 3rd and South Street in Philadelphia, Pennsylvania.[3] His father, Joseph Feinberg (who was Russian-Jewish), and mother, Fanny Lieberman, owned a watch repair and jewelry shop. In early childhood, his arm was burned with acid that his father used to test whether or not gold was real: having mistaken it for a beverage, Larry had raised the acid bottle to his lips when his father noticed and knocked it from his hand, accidentally splashing Larry's forearm. He was later given violin lessons to help strengthen the damaged muscles, a skill which would be put to use in many of the Stooges' films. He became proficient on the instrument, and his parents wanted to send him to a European music conservatory, but the outbreak of World War I prevented this. In scenes where all three Stooges are playing fiddles, only Larry is actually playing while the other two are only pantomiming. To strengthen his arm further, Larry took up boxing in his teens, fighting in (and winning) one professional bout. His father, opposed to Larry's fighting in public, put an end to his brief career as a boxer.[1]"
            },
            new Employee{
              Name = "Curly",
              Id = 13,
              DateHired = DateTime.Now.AddDays(-1),
              Bio = "Curly Howard was born Jerome Lester Horwitz in the Bensonhurst section of the Brooklyn borough of New York City. He was the fifth of the five Horwitz brothers and of Lithuanian Jewish ancestry. Because he was the youngest, his brothers called him Babe to tease him. The nickname stuck with him all his life, although when his older brother Shemp married Gertrude Frank, who was also nicknamed Babe, the brothers started calling him Curly to avoid confusion.[4]"
            }
        };

        public ActionResult List()
        {
            var model = employees;
            return View(model);
        }

    }
}
