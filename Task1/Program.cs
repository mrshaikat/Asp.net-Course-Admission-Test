(string name, int age)[] persons = new (string name, int age)[]
{
    ("tareq", 24),
    ("hasan" , 34),
    ("rafiq", 30),
    ("meem", 42),
    ("jitu", 34),
    ("rashed", 25),
    ("arif", 29)
};

 var result = from obj in persons
              where obj.age > 30
              orderby obj.name descending
              select obj;


string[] result;

/* Here write linq query to find names of persons that are above 30 years 
 * of age and names should be in descending order. put the result in result array.
 */