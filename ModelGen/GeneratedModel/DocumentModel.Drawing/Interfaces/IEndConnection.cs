namespace DocumentModel.Drawing;

/// <summary>
/// Connection End.
/// </summary>
public interface IEndConnection // : DocumentFormat.OpenXml.Drawing.ConnectionType
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
