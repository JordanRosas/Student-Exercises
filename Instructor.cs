using System;

public class Instructors
{

  public Instructors(string firstName, string lastName, string slackHandle, string instructorCohort){
    FirstName = firstName;
    LastName = lastName;
    SlackHandle = slackHandle;
    InstructorCohort = instructorCohort;
  }
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public string SlackHandle {get; set;}
  public string InstructorCohort {get; set;}
  public void AssignExercises(Student student, Exercises exercise){
    student.StudentExercises.Add(exercise);
  }

  public void ListInstructors(){
    Console.WriteLine($"Here are the instructors at NSS:{FirstName} {LastName} {InstructorCohort}");
  }

}