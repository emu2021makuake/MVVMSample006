using System;
using System.Threading;
using System.Threading.Tasks;

namespace MVVMSample006.Models
{
    public class HeavyWorkModel
    {
        public async Task HeavyWorkAsync(
            IProgress<ProgressInfo> progress,
            CancellationToken token)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    token.ThrowIfCancellationRequested();

                    await Task.Delay(50);

                    progress.Report(new ProgressInfo(i, $"{i + 1} cases processed."));
                }

                progress.Report(new ProgressInfo(0, "***** Done *****"));
            }
            catch (OperationCanceledException)
            {
                progress.Report(new ProgressInfo(0, "***** Cancelled *****"));
                return;
            }


        }
    }
}
