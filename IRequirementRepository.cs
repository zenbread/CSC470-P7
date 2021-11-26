using System.Collections.Generic;

namespace P7
{
    interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetAll(int ProjectId);
        string Modify(Requirement requirement);
        Requirement GetRequirementById(int requirementId);
        int CountByFeatureId(int featureId);
        void RemoveByFeatureId(int featureId);
    }
}
