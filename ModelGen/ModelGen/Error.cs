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
  public Error(PPS phase, ErrorCode code)
  {
    Phase = phase; Code = code;
  }

  /// <summary>
  /// Phase of the process that emmited this error
  /// </summary>
  public PPS Phase { get; set; }

  /// <summary>
  /// Error code
  /// </summary>
  public ErrorCode Code { get; set; }

}
