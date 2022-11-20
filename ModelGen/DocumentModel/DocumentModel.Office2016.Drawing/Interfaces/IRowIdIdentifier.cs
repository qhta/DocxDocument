namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the RowIdIdentifier Class.
/// </summary>
public interface IRowIdIdentifier // : DocumentFormat.OpenXml.Office2016.Drawing.OpenXmlIdentifierElement
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Val { get ; set; }
  
}
