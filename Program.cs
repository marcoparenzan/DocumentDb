using System.Threading.Tasks;
using DocumentDb.Demos;

namespace DocumentDb
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            await InsertDemo.RunAsync(args);
            // await AttachmentsDemo.RunAsync(args);
            // await DaemonDemo.RunAsync(args);
            // await CollectionsDemo.RunAsync(args);
            // await QueriesDemo.RunAsync(args);
            // await JoinDemo.RunAsync(args);
            // await RegionUserDefinedFunctionDemo.RunAsync(args);
            // await CountStoredProcedureDemo.RunAsync(args);
            // await NormalizeDocumentTriggerDemo.RunAsync(args);
            // await ClientSidePartitionsDemo.RunAsync(args);
        }
    }
}
