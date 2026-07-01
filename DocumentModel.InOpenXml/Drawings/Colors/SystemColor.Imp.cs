namespace DocumentModel.Drawings;

public partial class SystemColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32? RGB
  {
    get
    {
      if (LastColor is not null)
        return LastColor;
      if (this.Index is null)
        return null;
      var systemColor = this.Index.Value switch
      {
        SystemColors.ScrollBar => global::System.Drawing.SystemColors.ScrollBar,
        SystemColors.Background => global::System.Drawing.SystemColors.Desktop,
        SystemColors.ActiveCaption => global::System.Drawing.SystemColors.ActiveCaption,
        SystemColors.InactiveCaption => global::System.Drawing.SystemColors.InactiveCaption,
        SystemColors.Menu => global::System.Drawing.SystemColors.Menu,
        SystemColors.Window => global::System.Drawing.SystemColors.Window,
        SystemColors.WindowFrame => global::System.Drawing.SystemColors.WindowFrame,
        SystemColors.MenuText => global::System.Drawing.SystemColors.MenuText,
        SystemColors.WindowText => global::System.Drawing.SystemColors.WindowText,
        SystemColors.CaptionText => global::System.Drawing.SystemColors.ActiveCaptionText,
        SystemColors.ActiveBorder => global::System.Drawing.SystemColors.ActiveBorder,
        SystemColors.InactiveBorder => global::System.Drawing.SystemColors.InactiveBorder,
        SystemColors.ApplicationWorkspace => global::System.Drawing.SystemColors.AppWorkspace,
        SystemColors.Highlight => global::System.Drawing.SystemColors.Highlight,
        SystemColors.HighlightText => global::System.Drawing.SystemColors.HighlightText,
        SystemColors.ButtonFace => global::System.Drawing.SystemColors.Control,
        SystemColors.ButtonShadow => global::System.Drawing.SystemColors.ControlDark,
        SystemColors.GrayText => global::System.Drawing.SystemColors.GrayText,
        SystemColors.ButtonText => global::System.Drawing.SystemColors.ControlText,
        SystemColors.InactiveCaptionText => global::System.Drawing.SystemColors.InactiveCaptionText,
        SystemColors.ButtonHighlight => global::System.Drawing.SystemColors.ControlLightLight,
        SystemColors.ThreeDDarkShadow => global::System.Drawing.SystemColors.ControlDarkDark,
        SystemColors.ThreeDLight => global::System.Drawing.SystemColors.ControlLight,
        SystemColors.InfoText => global::System.Drawing.SystemColors.InfoText,
        SystemColors.InfoBack => global::System.Drawing.SystemColors.Info,
        SystemColors.HotLight => global::System.Drawing.SystemColors.HotTrack,
        SystemColors.GradientActiveCaption => global::System.Drawing.SystemColors.GradientActiveCaption,
        SystemColors.GradientInactiveCaption => global::System.Drawing.SystemColors.GradientInactiveCaption,
        SystemColors.MenuHighlight => global::System.Drawing.SystemColors.MenuHighlight,
        SystemColors.MenuBar => global::System.Drawing.SystemColors.MenuBar,
        _ => default(global::System.Drawing.Color)
      };
      return LastColor = (UInt32)(systemColor.ToArgb() & 0x00FFFFFF);
    }

    set => LastColor = value;
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Window", "WindowText", etc.
  /// If the color is not found in the SystemColors enumeration, the exception is raised.
  /// </summary>
  public override string? Name
  {
    get
    {
      if (this.RGB is not null)
      {
        var SystemColorField = typeof(SystemColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB.Value) == true);
        return SystemColorField?.Name;
      }

      return null;
    }

    set
    {
      if (value is null)
        return;
      if (Enum.TryParse<SystemColors>(value, out var SystemColor))
      {
        this.Index = SystemColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid System color.");
    }
  }

}
