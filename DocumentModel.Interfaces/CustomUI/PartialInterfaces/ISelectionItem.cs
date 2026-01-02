namespace DocumentModel;

/// <summary>
/// Element of the ComboBox, DropDown or Gallery selection.
/// </summary>
public interface ISelectionItem: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Specifies the identifier for a custom control. All new custom controls MUST have unique identifiers.
  ///   The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  ///   Specifies the relationship identifier for an image to be used as the icon for this control.
  ///   This attribute is used to specify an embedded picture that resides locally within the containing file.
  /// 
  ///   The Image and ImageMso attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   Specifies the identifier of a built-in image to be used as the icon of this control.
  /// 
  ///   The contents of this attribute are application-defined and SHOULD be ignored if not understood.
  ///
  ///   The Image and ImageMso attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Specifies a string to be shown as the screentip for this control.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Specifies a string to be shown as the supertip for this control.
  /// </summary>
  public string? Supertip
  {
    get; set;
  }