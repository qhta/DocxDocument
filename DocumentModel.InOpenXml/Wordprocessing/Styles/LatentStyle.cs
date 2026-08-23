namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents latent style exception information for a Wordprocessing document.
/// This class provides properties for style name, locking, UI priority, visibility, and primary style settings, enabling advanced management and customization of latent styles.
/// </summary>
[OpenXmlType(typeof(DXW.LatentStyleExceptionInfo))]
[DataContract]
[XmlRoot("LatentStyleExceptionInfo", Namespace = "DocumentModel.Wordprocessing")]
public partial class LatentStyle: ModelElement<DXW.LatentStyleExceptionInfo>
{
  /// <summary>
  /// Primary style name associated with the latent style exception.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.Name))]
  public string? Name
  {
    get => _Name ??= GetProperty<string?>(GetUpdatableElement()?.Name);
    set => UpdateField(ref _Name, value, nameof(Name));
  }

  private string? _Name;

  /// <summary>
  /// Indicates whether the latent style is locked and cannot be modified.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.Locked))]
  public bool? Locked
  {
    get => _Locked ??= GetProperty<bool?>(GetUpdatableElement()?.Locked);
    set => UpdateField(ref _Locked, value, nameof(Locked));
  }

  private bool? _Locked;

  /// <summary>
  /// Override for the default sorting order in the UI, specifying the priority of the style.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.UiPriority))]
  public Int32? UiPriority
  {
    get => _UiPriority ??= GetProperty<Int32?>(GetUpdatableElement()?.UiPriority);
    set => UpdateField(ref _UiPriority, value, nameof(UiPriority));
  }

  private Int32? _UiPriority;

  /// <summary>
  /// Indicates whether the style is semi-hidden, overriding default visibility settings.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.SemiHidden))]
  public bool? SemiHidden
  {
    get => _SemiHidden ??= GetProperty<bool?>(GetUpdatableElement()?.SemiHidden);
    set => UpdateField(ref _SemiHidden, value, nameof(SemiHidden));
  }

  private bool? _SemiHidden;

  /// <summary>
  /// Indicates whether the style should be unhidden when used in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.UnhideWhenUsed))]
  public bool? UnhideWhenUsed
  {
    get => _UnhideWhenUsed ??= GetProperty<bool?>(GetUpdatableElement()?.UnhideWhenUsed);
    set => UpdateField(ref _UnhideWhenUsed, value, nameof(UnhideWhenUsed));
  }

  private bool? _UnhideWhenUsed;

  /// <summary>
  /// Indicates whether the style is a primary style in the latent style set.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LatentStyleExceptionInfo.PrimaryStyle))]
  public bool? PrimaryStyle
  {
    get => _PrimaryStyle ??= GetProperty<bool?>(GetUpdatableElement()?.PrimaryStyle);
    set => UpdateField(ref _PrimaryStyle, value, nameof(PrimaryStyle));
  }

  private bool? _PrimaryStyle;
}