namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents latent style information for a Wordprocessing document.
/// This class provides properties for default style locking, UI priority, visibility, primary style settings, and style count, enabling advanced management and customization of latent styles.
/// </summary>
[OpenXmlType(typeof(DXW.LatentStyles))]
[OpenXmlItem(typeof(DXW.LatentStyleExceptionInfo))]
public partial class LatentStyles : ModelElementCollection<LatentStyleExceptionInfo, DXW.LatentStyles, DXW.LatentStyleExceptionInfo>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public LatentStyles()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "styles"></param>
  public LatentStyles(Styles styles): base(styles)
  {
    Styles = styles;
  }

  /// <summary>
  /// Parent styles element that contains this collection of defined styles. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Styles? Styles { get => _Styles; set => UpdateField(ref _Styles, value, nameof(Styles)); }

  private Styles? _Styles;
  /// <summary>
  /// Default style locking setting, indicating whether styles are locked by default.
  /// </summary>
  public bool? DefaultLockedState { get => _DefaultLockedState; set => UpdateField(ref _DefaultLockedState, value, nameof(DefaultLockedState)); }

  private bool? _DefaultLockedState;
  /// <summary>
  /// Default user interface priority setting, specifying the default sorting order for styles in the UI.
  /// </summary>
  public Int32? DefaultUiPriority { get => _DefaultUiPriority; set => UpdateField(ref _DefaultUiPriority, value, nameof(DefaultUiPriority)); }

  private Int32? _DefaultUiPriority;
  /// <summary>
  /// Default semi-hidden setting, indicating whether styles are semi-hidden by default.
  /// </summary>
  public bool? DefaultSemiHidden { get => _DefaultSemiHidden; set => UpdateField(ref _DefaultSemiHidden, value, nameof(DefaultSemiHidden)); }

  private bool? _DefaultSemiHidden;
  /// <summary>
  /// Default hidden until used setting, indicating whether styles are hidden until used by default.
  /// </summary>
  public bool? DefaultUnhideWhenUsed { get => _DefaultUnhideWhenUsed; set => UpdateField(ref _DefaultUnhideWhenUsed, value, nameof(DefaultUnhideWhenUsed)); }

  private bool? _DefaultUnhideWhenUsed;
  /// <summary>
  /// Default primary style setting, indicating whether styles are primary by default.
  /// </summary>
  public bool? DefaultPrimaryStyle { get => _DefaultPrimaryStyle; set => UpdateField(ref _DefaultPrimaryStyle, value, nameof(DefaultPrimaryStyle)); }

  private bool? _DefaultPrimaryStyle;
}