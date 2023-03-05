using System.Runtime.CompilerServices;

namespace JsonIssue;

public class BaseClass : VerifyMSTest.VerifyBase {

}

[TestClass]
public class UnitTest1 :  BaseClass
{
    [AssemblyInitialize] 
    public static void AssemblyInitialize(TestContext tc) {
        VerifierSettings.UseStrictJson();
    }

    [TestMethod]
    public async Task VerifyJson()
    {
        await VerifyJson(File.ReadAllText(getFilename()));

        string getFilename([CallerFilePath] string currentFile = "") {
            return Path.ChangeExtension( currentFile, "VerifyJson.verified.json");
        }
    }


}