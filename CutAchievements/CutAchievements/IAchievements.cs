﻿using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutAchievements
{
    public interface IAchievements
    {
        void RegisterAchievement(string uniqueID, bool secret, ModBehaviour mod);
        void RegisterTranslation(string uniqueID, TextTranslation.Language language, string name, string description);
        void RegisterTranslationsFromFiles(ModBehaviour mod, string folderPath);
        void EarnAchievement(string uniqueID);
        void UpdateProgress(string uniqueID, int current, int final, bool showPopup);
        int GetProgress(string uniqueID);
    }
}
