using System;
using System.Collections.Generic;
using System.Linq;

namespace Juggler
{
    public class JdkPath : IPath
    {
        public void Change(string newJdkPath, List<string> pathPatterns)
        {
            List<string> pathVars = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine).Split(';').OfType<string>().ToList();
            List<string> newPathVars = new List<string>();
            bool isFounded = false;
            foreach (string pathVar in pathVars)
            {
                string pathVarLower = pathVar.ToLower();
                if (!isFounded)
                {
                    foreach (string pathPattern in pathPatterns)
                    {
                        if (pathVarLower.Contains(pathPattern.ToLower()))
                        {
                            newPathVars.Add(newJdkPath + "\\bin");
                            isFounded = true;
                            break;
                        }
                    }

                    if (!isFounded)
                    {
                        newPathVars.Add(pathVar);
                    }
                }
                else
                {
                    newPathVars.Add(pathVar);
                }
            }

            string newPath = string.Join(";", newPathVars);
            Environment.SetEnvironmentVariable("JAVA_HOME", newJdkPath, EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.Machine);
        }
    }
}
