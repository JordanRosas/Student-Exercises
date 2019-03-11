using System.Collections.Generic;

public class Student
{
  public Student(string firstName, string lastName, string slackHandle){
    FirstName = firstName;
    LastName = lastName;
    SlackHandle = slackHandle;
    StudentExercises = new List<Exercises>();
  }
  public string FirstName {get; set;}

  public string LastName {get; set;}

  public string SlackHandle {get; set;}

  public string StudentCohort {get; set;}

  public List<Exercises> StudentExercises {get; set;}
  
}