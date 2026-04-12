namespace DocumentModel.Drawings;

public partial class SystemColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32? RGB
  {
    get
    {
      if (LastColor is not null)
        return LastColor;
      if (this.Val is null)
        return null;
      var systemColor = this.Val.Value switch
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
  /// Red component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Red
  {
    get => ((this.RGB >> 16) & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var red = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0x00FFFF | (red << 16);
    }
  }

  /// <summary>
  /// Green component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no green and 1 represents full green (255 in RGB).
  /// This is derived from the RGB+ value, where the green component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the green component while preserving the red and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Green
  {
    get => ((this.RGB >> 8) & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var green = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0xFF00FF | (green << 8);
    }
  }

  /// <summary>
  /// Blue component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no blue and 1 represents full blue (255 in RGB).
  /// This is derived from the RGB+ value, where the blue component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the blue component while preserving the red and green components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Blue
  {
    get => (this.RGB & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var blue = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0xFFFF00 | blue;
    }
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Accent1", "Accent2", etc.
  /// If the color is not found in the SystemColors enumeration, the exception is raised.
  /// </summary>
  string? IColor.Name
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
        this.Val = SystemColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid System color.");
    }
  }

  /// <summary>
  /// Tint modification of the color, represented as a percentage value between 0 and 1.
  /// </summary>
  double? IColor.Tint { get => this.Tint / 100000.0; set => this.Tint = value is null ? null : (int?)System.Math.Round((double)(value.Value * 100000.0)); }

  /// <summary>
  /// Shade modification of the color, represented as a percentage value between 0 and 1.
  /// </summary>
  double? IColor.Shade { get => this.Shade / 100000.0; set => this.Shade = value is null ? null : (int?)System.Math.Round((double)(value.Value * 100000.0)); }
}
