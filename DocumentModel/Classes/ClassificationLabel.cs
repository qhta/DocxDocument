namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ClassificationLabel Class.
/// </summary>
public class ClassificationLabel: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   enabled, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   setDate, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? SetDate { get; set; }

  /// <summary>
  ///   method, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? Method { get; set; }

  /// <summary>
  ///   name, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   siteId, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? SiteId { get; set; }

  /// <summary>
  ///   actionId, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? ActionId { get; set; }

  /// <summary>
  ///   contentBits, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public UInt32? ContentBits { get; set; }

  /// <summary>
  ///   removed, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public bool? Removed { get; set; }
}
