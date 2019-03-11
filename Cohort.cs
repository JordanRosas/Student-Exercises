using System.Collections.Generic;

public class Cohort
{
  public Cohort(string cohortname ){
    CohortName = cohortname;
    StudentList = new List<Student>();
    InstructorList = new List<Instructors>();
  }

  // public int CohortId {get; set;}
  public string CohortName {get; set;}
  public List<Student> StudentList {get; set;}
  public List<Instructors> InstructorList {get; set;}

}