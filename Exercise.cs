using System;

public class Exercises
{
  public Exercises(string exerciseName, string exerciseLanguage){
    ExerciseName = exerciseName;
    ExerciseLanguage = exerciseLanguage;
  }
  public string ExerciseName {get; set;}
  public string ExerciseLanguage {get; set;}

  public void printExercises(){
    Console.WriteLine($"The exercise is {ExerciseName} and the coding language is {ExerciseLanguage}");
  }

  public void ListExercises(){
    Console.WriteLine($"Available assignments for students: {ExerciseName} in {ExerciseLanguage}");
  }
}