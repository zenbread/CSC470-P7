﻿namespace P7
{
    public interface IPreferenceRepository
    {
        string GetPreference(string UserName, string PreferenceName);
        string SetPreference(string UserName, string PreferenceName, string Value);
    }
}
