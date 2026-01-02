namespace DocumentModel;

/// <summary>
///   Defines the common properties for all Sdt controls
/// </summary>
public interface ICustomControlBase: IIdentifiedElement
{
  /// <summary>
  ///   Specifies a qualified identifier for a control.
  ///   The QualifiedId attribute can be used to reference controls or containers created by other Custom UI documents.
  /// 
  ///   The Id, QualifiedId, and IdMso attributes are mutually exclusive. At least one of these attributes MUST be specified.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Specifies the identifier of a built-in control that this control is to be inserted after. If the value of this attribute is not understood, it SHOULD be ignored.
  ///   The insertAfterMso, InsertAfterQualifiedId, insertBeforeMso, and InsertBeforeQualifiedId attributes are mutually exclusive.
  ///   If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Specifies the identifier of a built-in control that this control is to be inserted before. If the value of this attribute is not understood, it SHOULD be ignored.
  /// 
  ///   The InsertAfterMso, InsertAfterQualifiedId, InsertBeforeMso, and InsertBeforeQualifiedId attributes are mutually exclusive.
  ///   If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Specifies the qualified identifier of a control that this control is to be inserted after. If the value of this attribute is not understood, it SHOULD be ignored,
  /// 
  ///   The InsertAfterMso, InsertAfterQualifiedId, InsertBeforeMso, and InsertBeforeQualifiedId attributes are mutually exclusive.
  ///   If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML.
  /// </summary>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Specifies the identifier of a built-in control that this control is to be inserted before. If the value of this attribute is not understood, it SHOULD be ignored.
  /// 
  ///   The InsertAfterMso, InsertAfterQualifiedId, InsertBeforeMso, and InsertBeforeQualifiedId attributes are mutually exclusive.
  ///   If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML.
  ///  </summary>
  public string? InsertBeforeQualifiedId { get; set; }
}