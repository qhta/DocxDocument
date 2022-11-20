namespace DocumentModel.Drawing;

/// <summary>
/// Connection Start.
/// </summary>
public interface IStartConnection // : DocumentFormat.OpenXml.Drawing.ConnectionType
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
