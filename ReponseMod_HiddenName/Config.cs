using Rocket.API;

namespace ReponseMod_HiddenName
{
    public class Config : IRocketPluginConfiguration
    {
        public string PolicePerm;
        public string DoctorPerm;
        public string AdminPerm;

        public void LoadDefaults()
        {
            throw new System.NotImplementedException();
        }
    }
}