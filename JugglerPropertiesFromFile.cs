using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace Juggler
{
    internal class JugglerPropertiesFromFile : IProperties<JugglerPropertiesDTO>
    {
        private JugglerPropertiesDTO props;
        private readonly string jugglerPropertiesDir;
        private readonly string jugglerPropertiesPath;

        public JugglerPropertiesFromFile()
        {
            jugglerPropertiesDir = Environment.GetEnvironmentVariable("USERPROFILE") + "\\.juggler";
            jugglerPropertiesPath = jugglerPropertiesDir + "\\settings.json";
            Init();
        }

        public JugglerPropertiesFromFile(string jugglerPropertiesDir, string jugglerPropertiesName)
        {
            this.jugglerPropertiesDir = jugglerPropertiesDir;
            jugglerPropertiesPath = jugglerPropertiesDir + "\\" + jugglerPropertiesName;
            Init();
        }

        public JugglerPropertiesDTO Get()
        {
            return props;
        }

        public void Save()
        {
            File.WriteAllText(jugglerPropertiesPath, JsonSerializer.Serialize(props));
        }

        private void Init()
        {
            if (File.Exists(jugglerPropertiesPath))
            {
                string rawSettings = File.ReadAllText(jugglerPropertiesPath);
                if (rawSettings != null || rawSettings != "" || rawSettings != "{}")
                {
                    props = JsonSerializer.Deserialize<JugglerPropertiesDTO>(File.ReadAllText(jugglerPropertiesPath));
                }
                else
                {
                    InitProps();
                }
            }
            else
            {
                InitProps();
            }

            if (props.JavaPropertiesDTO.JdkPathPatterns.Count == 0)
            {
                props.JavaPropertiesDTO.JdkPathPatterns = new List<string>() { "\\java\\jdk" };
            }

            if (!Directory.Exists(jugglerPropertiesDir))
            {
                Directory.CreateDirectory(jugglerPropertiesDir);
            }
        }
        
        private void InitProps()
        {
            props.JavaPropertiesDTO = new JavaPropertiesDTO();
            props.JavaPropertiesDTO.JdkPropertiesDTOs = new List<JdkPropertiesDTO>();
            props.JavaPropertiesDTO.JdkPathPatterns = new List<string>() { "\\java\\jdk" };
        }
    }
}
