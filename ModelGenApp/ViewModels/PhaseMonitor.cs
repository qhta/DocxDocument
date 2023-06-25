using System.ComponentModel;
using System.Diagnostics;

namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public partial class PhaseMonitor : ViewModel
{
  /// <summary>
  /// Id of the process phase.
  /// </summary>
  public PPS PhaseNumber
  {
    get => _PhaseNumber;
    set
    {
      if (value != _PhaseNumber)
      {
        _PhaseNumber = value;
        NotifyPropertyChanged(nameof(PhaseNumber));
      }
    }
  }
  private PPS _PhaseNumber;


  /// <summary>
  /// Name of the process phase.
  /// </summary>
  public string? PhaseName
  {
    get => _PhaseName;
    set 
    {
      if (value != _PhaseName)
      {
        _PhaseName = value;
        NotifyPropertyChanged(nameof(PhaseName));
      }
    }
  }
  private string? _PhaseName;


  public int Percentage
  {
    get { return _Percentage; }
    set
    {
      if (_Percentage != value)
      {
        _Percentage = value;
        NotifyPropertyChanged(nameof(Percentage));
      }
    }
  }
  private int _Percentage;


  //private SummaryInfo? SummaryInfo;

  private BackgroundWorker worker;

  public PhaseMonitor()
  {
    worker = new BackgroundWorker();
    worker.WorkerReportsProgress = true;
    worker.ProgressChanged += (sender, args) =>
    {
      Debug.WriteLine($"ProgressChanged.Begin({args.ProgressPercentage})");
      DispatcherHelper.Execute(() => Percentage = args.ProgressPercentage);
      Debug.WriteLine($"ProgressChanged.End({args.ProgressPercentage})");
    };
    worker.DoWork += WorkerDoWork;
    worker.RunWorkerAsync();

  }
  //public void Load()
  //{
  //  worker.RunWorkerAsync();
  //}

  private void WorkerDoWork(object? sender, DoWorkEventArgs e)
  {
    Debug.WriteLine($"Worker.DoWork.Begin({Percentage})");
    worker.ReportProgress(Percentage);
    Thread.Sleep(100);
    Debug.WriteLine($"Worker.DoWork.End({Percentage})");
  }
}
