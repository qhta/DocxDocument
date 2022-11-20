namespace DocumentModel.Office2021.MipLabelMetaData;

/// <summary>
/// Defines the ClassificationLabel Class.
/// </summary>
public interface IClassificationLabel // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// enabled, this property is only available in Office 2021 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// setDate, this property is only available in Office 2021 and later.
  /// </summary>
  public string? SetDate { get ; set; }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Method { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? SiteId { get ; set; }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? ActionId { get ; set; }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  public uint? ContentBits { get ; set; }
  
  /// <summary>
  /// removed, this property is only available in Office 2021 and later.
  /// </summary>
  public bool? Removed { get ; set; }
  
}
