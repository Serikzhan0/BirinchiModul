using lesson_2.Models;

namespace lesson_2.Services;

public class SchoolService
{
    public List<School> Schools = new List<School>();

    public Guid AddSchool(School school)
    {
        school.SchoolId = Guid.NewGuid();
        Schools.Add(school);
        return school.SchoolId;
    }

    public List<School> GetAllSchools()
    {
        return Schools;
    }

    public School GetById(Guid schoolId)
    {
        School school = null;

        foreach (var s in Schools)
        {
            if (s.SchoolId == schoolId)
            {
                school = s;
                break;
            }
        }

        return school;
    }

    public bool DeleteSchool(Guid schoolId)
    {
        foreach (var school in Schools)
        {
            if (school.SchoolId == schoolId)
            {
                Schools.Remove(school);
                return true;
            }
        }
        return false;
    }

    public void UpdateSchool(School updatedSchool)
    {
        School existingSchool = null;

        foreach (var school in Schools)
        {
            if (school.SchoolId == updatedSchool.SchoolId)
            {
                existingSchool = school;
                break;
            }
        }

        if (existingSchool != null)
        {
            existingSchool.Name = updatedSchool.Name;
            existingSchool.Address = updatedSchool.Address;
            existingSchool.StudentsCount = updatedSchool.StudentsCount;
            existingSchool.TeachersCount = updatedSchool.TeachersCount;
            existingSchool.Director = updatedSchool.Director;
        }
    }
}