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
    public async Task SimpleVerify()
    {
        await Verify("Hello world");
    }


    [TestMethod]
    public async Task GeneratorVerify()
    {
        var json  = "{ 'HelloWord': true}";
        var log = "some log";
        await VerifyJson(json);
        await Verify(log);
    }

    [TestMethod]
    public async Task AnotherSimpleVerify()
    {
        await Verify("Hello world");
    }
}