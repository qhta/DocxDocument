namespace DocumentModel;

/// <summary>
/// Defines members for specifying a detailed description of a control, either directly or via a callback function, for
/// use in detailed views.
/// </summary>
/// <remarks>Implementations should ensure that only one of the Description or GetDescription properties is set at
/// a time, as they are mutually exclusive. If neither property is specified, no detailed text should be displayed for
/// the control.</remarks>
public interface IDescriptionControl
{
  /// <summary>
  ///   Specifies a detailed description of the control, which is displayed in detailed views.
  ///
  ///  The Description and GetDescription attributes are mutually exclusive. If neither attribute is specified, the control SHOULD NOT display any detailed text.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the detailed description of this control.
  ///
  ///   The GetDescription and Description attributes are mutually exclusive. If neither attribute is specified, the control SHOULD NOT display any detailed text.
  /// </summary>
  public string? GetDescription { get; set; }
}