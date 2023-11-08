namespace ModelGen;

/// <summary>
/// Processing fixage class
/// </summary>
public record Fixage
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Fixage() { }

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="phase"></param>
  /// <param name="code"></param>
  /// <param name="args"></param>
  public Fixage(PPS phase, ErrorCode code, object[]? args = null)
  {
    Phase = phase; Code = code; Args = args;
  }

  /// <summary>
  /// Phase of the process that emmited this error
  /// </summary>
  public PPS Phase { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Error code
  /// </summary>
  public ErrorCode Code { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Additional info.
  /// </summary>
  public object[]? Args {get; set; }

}
