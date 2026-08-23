namespace DocumentModel;

/// <summary>
/// Exception thrown when an operation cannot be performed because this feature is unavailable in the specific interface implementation. 
/// </summary>
public class UnavailableException : Exception
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public UnavailableException() { }

  /// <summary>
  /// Constructor with a custom message.
  /// </summary>
  /// <param name="message">The message that describes the error.</param>
  public UnavailableException(string message) : base(message) { }

  /// <summary>
  /// Constructor with custom message and inner exception for more detailed error information.
  /// </summary>
  /// <param name="message">The message that describes the error.</param>
  /// <param name="inner">The inner exception that caused the current exception.</param>
  public UnavailableException(string message, Exception inner) : base(message, inner) { }
}