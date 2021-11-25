using System.Collections.Generic;

namespace P7
{
    interface IFeatureRepository
    {
        string Add(Feature feature);
        List<Feature> GetAll(int ProjectId);
        string Remove(Feature feature);
        string Modify(Feature feature);
        Feature GetFeatureById(int projectId, int featureId);
        Feature GetFeatureByTitle(int projectId, string title);
    }
}
