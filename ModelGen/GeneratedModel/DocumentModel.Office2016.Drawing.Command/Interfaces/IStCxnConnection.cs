namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the StCxnConnection Class.
/// </summary>
public interface IStCxnConnection // : DocumentFormat.OpenXml.Office2016.Drawing.Command.ConnectionType
{
  /// <summary>
  /// Identifier
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public uint? Index { get ; set; }
  
}
