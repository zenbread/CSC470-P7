using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public const string EMPTY_TITLE_ERROR = "Title must have a value.";
        public const string NOT_FOUND_ERROR = "Feature not found.";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for feature.";
        private static List<Feature> _features = new List<Feature>();
        public FakeFeatureRepository()
        {
            if (_features.Count() == 0)
            {
                _features.Add(new Feature { Id = GetNextId(), ProjectId = 1, Title = "Get Account working." });
                _features.Add(new Feature { Id = GetNextId(), ProjectId = 1, Title = "Take names" });
                _features.Add(new Feature { Id = GetNextId(), ProjectId = 1, Title = "Handle Taxes" });
            }
        }

        private bool CheckBadProjectId(int projectId)
        {
            FakeProjectRepository projRepo = new FakeProjectRepository();
            List<Project> projs = projRepo.GetAll();
            bool check = true;
            foreach (Project p in projs)
            {
                if (projectId == p.Id)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        private Feature isDuplicate(Feature feature)
        {
            return _features.Find(x => x.ProjectId == feature.ProjectId && x.Title == feature.Title);
        }

        private string ValidateFeature(Feature feature)
        {
            if (string.IsNullOrEmpty(feature.Title))
                return EMPTY_TITLE_ERROR;
            else if (isDuplicate(feature) != null)
                return DUPLICATE_TITLE_ERROR;
            else if (CheckBadProjectId(feature.ProjectId))
                return INVALID_PROJECT_ID_ERROR;
            else
                return NO_ERROR;
        }
        public string Add(Feature feature)
        {
            feature.Id = GetNextId();
            string check = ValidateFeature(feature);
            if (check == "")
            {
                _features.Add(feature);
            }
            return check;  
        }

        public List<Feature> GetAll(int ProjectId)
        {
            return _features;
        }

        public Feature GetFeatureById(int projectId, int featureId)
        {
            Feature feature = null;
            foreach (Feature f in _features)
            {
                if (f.Id == featureId && f.ProjectId == projectId)
                {
                    feature = f;
                    break;
                }
            }
            return feature;
        }

        public Feature GetFeatureByTitle(int projectId, string title)
        {
            Feature feature = null;
            foreach (Feature f in _features)
            {
                if (f.Title == title && f.ProjectId == projectId)
                {
                    feature = f;
                    break;
                }
            }
            return feature;
        }

        public string Modify(Feature feature)
        {
            string check = ValidateFeature(feature);
            if (check == "" || check == DUPLICATE_TITLE_ERROR)
            {
                check = NO_ERROR;
                foreach (Feature f in _features)
                {
                    if (f.Id == feature.Id)
                    {
                        f.Title = feature.Title;
                    }
                }
            }
            return check;
        }

        public string Remove(Feature feature)
        {
            string check = NO_ERROR;
            if (!_features.Remove(feature))
            {
                check = NOT_FOUND_ERROR;
            }
            return check;
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Feature f in _features)
            {
                currentMaxId = f.Id;
            }
            return ++currentMaxId;
        }
    }
}
