namespace ModelGen;

/// <summary>
/// Processing error class
/// </summary>
public record Error
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Error() { }

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="phase"></param>
  /// <param name="code"></param>
  /// <param name="args"></param>
  public Error(PPS phase, ErrorCode code, object[]? args = null)
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
