using System;
using System.Collections.Generic;
using System.Linq;

namespace P7
{
    class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        public const string EMPTY_STATEMENT_ERROR = "Statements must have a value.";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";
        private static List<Requirement> requirements = new List<Requirement>();
        public FakeRequirementRepository()
        {
            if (requirements.Count() == 0)
            {
                requirements.Add(new Requirement { Id = GetNextId(), FeatureId = 1, ProjectId = 1, Statement = "First requirement."});
                requirements.Add(new Requirement { Id = GetNextId(), FeatureId = 1, ProjectId = 1, Statement = "Second requirement."});
                requirements.Add(new Requirement { Id = GetNextId(), FeatureId = 2, ProjectId = 1, Statement = "Third requirement."});
            }
        }
        private string DuplicateStatement(Requirement r)
        {
            string check = NO_ERROR;
            Requirement found = requirements.Find(x => x.Id != r.Id && x.Statement == r.Statement);
            if (found != null)
                check = DUPLICATE_STATEMENT_ERROR;
            return check;
        }
        public string Add(Requirement requirement)
        {
            requirement.Id = GetNextId();
            if (string.IsNullOrEmpty(requirement.Statement))
                return EMPTY_STATEMENT_ERROR;
            else if (requirement.ProjectId <= 0)
                return MISSING_PROJECTID_ERROR;
            else if (requirement.FeatureId <= 0)
                return MISSING_FEATUREID_ERROR;
            else if (DuplicateStatement(requirement) != NO_ERROR)
                return DUPLICATE_STATEMENT_ERROR;

            requirements.Add(requirement);
            
            return NO_ERROR;
        }

        public int CountByFeatureId(int featureId)
        {
            int count = 0;
            foreach (Requirement r in requirements)
            {
                if (r.FeatureId == featureId)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Requirement> GetAll(int ProjectId)
        {
            return requirements;
        }

        public Requirement GetRequirementById(int requirementId)
        {
            Requirement requirement = null;
            foreach(Requirement r in requirements)
            {
                if (r.Id == requirementId)
                {
                    requirement = r;
                    break;
                }
            }
            return requirement;
        }

        public string Modify(Requirement requirement)
        {
            
            string check = NO_ERROR;
            if (!requirements.Exists(x => x.Id == requirement.Id))
                return REQUIREMENT_NOT_FOUND_ERROR;
            else if (string.IsNullOrEmpty(requirement.Statement))
                return EMPTY_STATEMENT_ERROR;
            else if (DuplicateStatement(requirement) != NO_ERROR)
                return DUPLICATE_STATEMENT_ERROR;
            if (check == NO_ERROR)
            {
                foreach (Requirement r in requirements)
                {
                    if (requirement.Id == r.Id)
                    {
                        r.FeatureId = requirement.FeatureId;
                        r.Statement = requirement.Statement;
                        break;
                    }

                }
            }
            return check;
        }

        public void RemoveByFeatureId(int featureId)
        {
            foreach(Requirement r in requirements)
            {
                if (featureId == r.FeatureId)
                {
                    requirements.Remove(r);
                }
            }
        }

        public void Remove(Requirement r)
        {
            requirements.Remove(r);
        }
        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Requirement r in requirements)
            {
                currentMaxId = r.Id;
            }
            return ++currentMaxId;
        }
    }
}
