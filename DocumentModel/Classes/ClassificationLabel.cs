namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabel Class.
/// </summary>
public class ClassificationLabel: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   enabled, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? Enabled { get; set; }

  /// <summary>
  ///   setDate, this property is only available in Office 2021 and later.
  /// </summary>
  public String? SetDate { get; set; }

  /// <summary>
  ///   method, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Method { get; set; }

  /// <summary>
  ///   name, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   siteId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? SiteId { get; set; }

  /// <summary>
  ///   actionId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? ActionId { get; set; }

  /// <summary>
  ///   contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? ContentBits { get; set; }

  /// <summary>
  ///   removed, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? Removed { get; set; }
}