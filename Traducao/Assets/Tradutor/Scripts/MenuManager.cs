using UnityEngine;
using DFTGames.Localization;

namespace DFTGames
{
    public class MenuManager : MonoBehaviour
    {
        #region Public Methods

        public void SetEnglish()
        {
            Localize.SetCurrentLanguage(SystemLanguage.English);
            LocalizeImage.SetCurrentLanguage(SystemLanguage.English);
        }
        public void SetPortuguese()
        {
            Localize.SetCurrentLanguage(SystemLanguage.Portuguese);
            LocalizeImage.SetCurrentLanguage(SystemLanguage.Portuguese);
        }
        public void SetSpanish()
        {
            Localize.SetCurrentLanguage(SystemLanguage.Spanish);
            LocalizeImage.SetCurrentLanguage(SystemLanguage.Spanish);
        }
        

        #endregion Public Methods
    }
}