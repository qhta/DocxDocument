Colors used in the DocumentModel have various representations: 
- **Color\<T>** - abstract class that represents a model of a color based on an OpenXmlElement.
- **AnyColor** - a concrete implementation of Color\<T> that can represent any color model. 
- **Wordprocessing.Color** - a specific implementation of Color\<T> for WordprocessingML colors.
- **Drawings.RgbColorModelHex** - a specific implementation of Color\<T> for RGB colors in hexadecimal model in DrawingsML 
- **Drawings.RgbColorModelPercentage** - a specific implementation of Color\<T> for RGB colors in percentage model in DrawingsML.
- **Drawings.SchemeColor** - a specific implementation of Color\<T> for scheme colors in DrawingsML.
- **Drawings.SystemColor** - a specific implementation of Color\<T> for system colors in DrawingsML.
- **Drawings.PresetColor** - a specific implementation of Color\<T> for preset colors in DrawingsML.
- **Drawings.HslColorModel** - a specific implementation of Color\<T> for HSL colors in DrawingsML.
- **Wordprocessing.RgbColorModelHex** - a specific implementation of Color\<T> for RGB colors in hexadecimal model in WordprocessingML.
- **Wordprocessing.SchemeColor** - a specific implementation of Color\<T> for scheme colors in WordprocessingML.

# Drawings color classes

The Drawings color classes represent different color models and allow for flexible color specifications in drawings, charts, and other graphical elements.
Many of their properties use two base types of values: **Drawings.Percentage** and **Drawings.Degree**.

All Drawings color classes are based on the **Drawings.ColorBase\<T>** abstract class, which provides common properties and methods for color manipulation, such as tint and shade adjustments.

## Drawings.Percentage class

All percentage values in the Drawings classes are represented by **Drawings.Percentage** class, 
which stores the value as a long integer value, where the value is scaled by 100,000 to preserve precision.
This class supports implicit conversions to/from numeric types and string representations with optional "%" suffix.
The following conversion rules apply:
- Numeric conversion to/from integer types (e.g., int, long, ushort, uint) treats the value as a raw integer representing the scaled percentage.
For example, a value of 5000 corresponds to 5% and 10000 corresponds to 10%.</item>
- Numeric conversion to/from floating-point types (e.g., float, double, decimal) treats the value as a scaled percentage.
For example, a value of 0.5 corresponds to 50% and 1.0 corresponds to 100%.
- String conversion with the "%" suffix represents percentage scale.
For example, a raw value of 5000 corresponds to "5%", and a raw value of 10000 corresponds to "10%".
- String conversion without the "%" suffix represents the value as a raw integer number and is not scaled.
For example, a string value of "30000" corresponds to a raw value of 30000, and "60000" corresponds to a raw value of 60000.
Use of decimal separator in string input without the "%" suffix is not supported and will result in a parsing error, as it is treated as a raw integer value.

## Drawings.Degree class

A **Hue** property in the HSL color model is represented by **Drawings.Degree** class, which stores the value as a long integer value, where the value is scaled by 60,000 to preserve precision.
This class supports implicit conversions to/from numeric types and string representations with an optional "°" suffix.
The following conversion rules apply:
- Numeric conversion to/from integer types (e.g., int, long, ushort, uint) treats the value as a raw integer representing the scaled angle.
For example, a value of 30000 corresponds to raw value of 30000 (0.5 degree) and 60000 corresponds to raw value of 60000 (1 degree).
- Numeric conversion to/from floating-point types (e.g., float, double, decimal) treats the value as a scaled angle in degrees.
For example, a value of 0.5 corresponds to raw 30000 integer value, and 1.0 corresponds to raw 60000 integer value.
- String conversion with the "°" suffix represents degree scale.
For example, a raw value of 30000 corresponds to "0.5°", and a raw value of 60000 corresponds to "1°".
- String conversion without the "°" suffix represents the value as a raw integer number and is not scaled.
For example, a string value of "30000" corresponds to a raw value of 30000, and "60000" corresponds to a raw value of 60000.
Use of decimal separator in string input without the "°" suffix is not supported and will result in a parsing error, as it is treated as a raw integer value.

## Drawings.DrawingsColorBase<T> class

The **Drawings.DrawingsColorBase\<T>** class is an abstract base class for all color models in the Drawings namespace.
It provides common properties and methods for color manipulation, such as tint and shade adjustments.
It has the following properties:
- **Tint** - An optional property that represents the tint of the color. It is a percentage value that can be used to lighten the color. A value of 0% means no change, while a value of 100% means the color is completely white (lightened).
- **Shade** - An optional property that represents the shade of the color. It is a percentage value that can be used to darken the color. A value of 0% means no change, while a value of 100% means the color is completely black (darkened).
- **Complement** - An optional property that indicates whether the complement (opposite) color operation is applied. When set to true, the color is transformed to its complement value on the color wheel (e.g., red becomes cyan, green becomes magenta). Default is false.
- **Inverse** - An optional property that indicates whether the color inversion operation is applied. When set to true, each RGB component is inverted (255 - value), creating a negative effect. Default is false.
- **Gray** - An optional property that indicates whether the color is converted to grayscale. When set to true, the color is desaturated to create a grayscale value based on the perceived luminance of the original color. Default is false.
- **Alpha** - An optional property that represents the absolute alpha (transparency) value. Specifies the opacity of the color where 0 is fully transparent and 100,000 is fully opaque (100%). Values between create semi-transparent colors. If null, full opacity (100,000) is assumed.
- **AlphaOffset** - An optional property that represents the alpha (transparency) offset adjustment. Adds or subtracts from the base alpha value. Range is typically -100,000 to +100,000. Positive values increase opacity, negative values increase transparency.
- **AlphaModulation** - An optional property that represents the alpha (transparency) modulation percentage. Multiplies the base alpha by this percentage. A value of 50,000 (50%) makes the color twice as transparent. Range is 0 to 100,000, where 100,000 means no change.
- **Hue** - An optional property that represents the absolute hue value in the HSL color space. Specifies the hue angle in degrees (0-360), represented as 0-21600000 units (1/60000th of a degree). Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
- **HueOffset** - An optional property that represents the hue offset adjustment in the HSL color space. Adds or subtracts from the base hue value to shift the color around the color wheel. Values wrap around (adding 360 degrees returns to the same hue).
- **HueModulation** - An optional property that represents the hue modulation percentage. Multiplies the base hue by this percentage. Used for relative hue adjustments. Range is 0 to 100,000, where 100,000 means no change.
- **Saturation** - An optional property that represents the absolute saturation value in the HSL color space. Specifies the color saturation where 0 is grayscale and 100,000 is fully saturated (100%). Saturation determines the intensity or vividness of the color.
- **SaturationOffset** - An optional property that represents the saturation offset adjustment in the HSL color space. Adds or subtracts from the base saturation value. Range is typically -100,000 to +100,000. Positive values make colors more vivid, negative values make them more gray.
- **SaturationModulation** - An optional property that represents the saturation modulation percentage in the HSL color space. Multiplies the base saturation by this percentage. A value of 50,000 (50%) reduces saturation by half. Range is 0 to 100,000, where 100,000 means no change.
- **Luminance** - An optional property that represents the absolute luminance value in the HSL color space. Specifies the brightness where 0 is black, 50,000 is the color at normal brightness (50%), and 100,000 is white. Luminance determines how light or dark the color appears.
- **LuminanceOffset** - An optional property that represents the luminance offset adjustment in the HSL color space. Adds or subtracts from the base luminance value. Range is typically -100,000 to +100,000. Positive values make colors lighter, negative values make them darker.
- **LuminanceModulation** - An optional property that represents the luminance modulation percentage in the HSL color space. Multiplies the base luminance by this percentage. A value of 50,000 (50%) reduces brightness by half. Range is 0 to 100,000, where 100,000 means no change. Commonly used to create lighter or darker variations.
- **Red** - An optional property that represents the absolute red channel value. Overrides the red component (0-100,000 representing 0-255). Use this to set an explicit red value independent of the base RGB color.
- **RedOffset** - An optional property that represents the red channel offset adjustment. Adds or subtracts from the red channel value. Range is typically -100,000 to +100,000.
- **RedModulation** - An optional property that represents the red channel modulation percentage. Multiplies the base red channel by this percentage. Range is 0 to 100,000, where 100,000 means no change. A value of 50,000 (50%) reduces the red component by half.
- **Green** - An optional property that represents the absolute green channel value. Overrides the green component (0-100,000 representing 0-255). Use this to set an explicit green value independent of the base RGB color.
- **GreenOffset** - An optional property that represents the green channel offset adjustment. Adds or subtracts from the green channel value. Range is typically -100,000 to +100,000.
- **GreenModulation** - An optional property that represents the green channel modulation percentage. Multiplies the base green channel by this percentage. Range is 0 to 100,000, where 100,000 means no change. A value of 50,000 (50%) reduces the green component by half.
- **Blue** - An optional property that represents the absolute blue channel value. Overrides the blue component (0-100,000 representing 0-255). Use this to set an explicit blue value independent of the base RGB color.
- **BlueOffset** - An optional property that represents the blue channel offset adjustment. Adds or subtracts from the blue channel value. Range is typically -100,000 to +100,000.
- **BlueModulation** - An optional property that represents the blue channel modulation percentage. Multiplies the base blue channel by this percentage. Range is 0 to 100,000, where 100,000 means no change. A value of 50,000 (50%) reduces the blue component by half.
- **Gamma** - An optional property that indicates whether gamma correction is applied. When set to true, applies standard gamma correction (typically gamma 2.2) to convert from linear RGB space to display-corrected RGB. Default is false. Gamma correction adjusts colors to appear correct on display devices.
- **InverseGamma** - An optional property that indicates whether inverse gamma correction is applied. When set to true, applies inverse gamma correction to convert from display-corrected RGB to linear RGB space. Default is false. This is the opposite of standard gamma correction.

## Drawings.RgbColorModelHex class

The **Drawings.RgbColorModelHex** class represents a color in the RGB color model using hexadecimal notation. 
It has the following properties:
- **Value** - A string property that holds the hexadecimal value of the color. The value should be in the format "RRGGBB", where RR, GG, and BB are two-digit hexadecimal numbers representing the red, green, and blue components of the color, respectively.

## Drawings.RgbColorModelPercentage class

The **Drawings.RgbColorModelPercentage** class represents a color in the RGB color model using percentage notation. 
It has the following properties:
- **R** - A percentage property that holds the value of the red component of the color. 
- **G** - A percentage property that holds the value of the green component of the color.
- **B** - A percentage property that holds the value of the blue component of the color.

The values for **R**, **G**, and **B** override the base **Red**, **Green**, and **Blue** properties 
in the **Drawings.DrawingsColorBase\<T>** class in that they are required to be set for the color to be valid, 
while the base properties are optional adjustments of the base color.

## Drawings.HslColor class

The **Drawings.HslColor** class represents a color in the HSL color model using percentage notation. 
It has the following properties:
- **H** - A property that specifies the hue of the color. It is a degree value that ranges from 0 to 360, where 0 represents red, 120 represents green, and 240 represents blue. 
- **S** - A percentage property that holds the value of the saturation component of the color. The values are in the range from "-100%" to "100%", where "0%" means no saturation (a shade of gray) and "100%" means full saturation (the pure color).
- **L** - A percentage property that holds the value of the lightness component of the color. The values are in the range from "-100%" to "100%", where "0%" means no saturation (a shade of gray) and "100%" means full saturation (the pure color).

The values for **H**, **S**, and **L** override the base **Hue**, **Saturation**, and **Luminance** properties 
in the **Drawings.DrawingsColorBase\<T>** class in that they are required to be set for the color to be valid, 
while the base properties are optional adjustments of the base color.

## Drawings.SchemeColor class

The **Drawings.SchemeColor** class represents a color that is defined in the color scheme of the document.
It has the following properties:
- **Index** - A property that holds the enumeration index to the scheme color table.
- **Tint** - An optional property that represents the tint of the color. It is a percentage value that can be used to lighten the color. A value of 0% means no change, while a value of 100% means the color is completely white (lightened).
- **Shade** - An optional property that represents the shade of the color. It is a percentage value that can be used to darken the color. A value of 0% means no change, while a value of 100% means the color is completely black (darkened).

The **Drawings.SchemeColors** enumeration defines the following standard scheme color names that can be used as values for the Index property of the **Drawings.SchemeColor** class:
- **Auto** = 0,
- **Dark1** = 1,
- **Light1** = 2,
- **Dark2** = 3,
- **Light2** = 4,
- **Accent1** = 5,
- **Accent2** = 6,
- **Accent3** = 7,
- **Accent4** = 8,
- **Accent5** = 9,
- **Accent6** = 10,
- **Hyperlink** = 11,
- **FollowedHyperlink** = 12,
- **Text1** = 17,
- **Background1** = 18,
- **Text2** = 19,
- **Background2** = 20,

## Drawings.PresetColor class

The **Drawings.PresetColor** class represents a color using a predefined color name with optional transformations.
This class allows colors to be specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette, with optional 
modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
The has the following properties:
- **Index** - A property that holds the enumeration value to the preset color table. 
- **Tint** - An optional property that represents the tint of the color. It is a percentage value that can be used to lighten the color. A value of 0% means no change, while a value of 100% means the color is completely white (lightened).
- **Shade** - An optional property that represents the shade of the color. It is a percentage value that can be used to darken the color. A value of 0% means no change, while a value of 100% means the color is completely black (darkened).

The **Drawings.PresetColors** enumeration defines the following standard preset color names that can be used as values for the Index property of the **Drawings.PresetColor** class:
- **AliceBlue** = 0x00F0F8FF
- **AntiqueWhite** = 0x00FAEBD7
- **Aqua** = 0x0000FFFF
- **Aquamarine** = 0x007FFFD4
- **Azure** = 0x00F0FFFF
- **Beige** = 0x00F5F5DC
- **Bisque** = 0x00FFE4C4
- **Black** = 0x00000000
- **BlanchedAlmond** = 0x00FFEBCD
- **Blue** = 0x000000FF
- **BlueViolet** = 0x008A2BE2
- **Brown** = 0x00A52A2A
- **BurlyWood** = 0x00DEB887
- **CadetBlue** = 0x005F9EA0
- **Chartreuse** = 0x007FFF00
- **Chocolate** = 0x00D2691E
- **Coral** = 0x00FF7F50
- **CornflowerBlue** = 0x006495ED
- **Cornsilk** = 0x00FFF8DC
- **Crimson** = 0x00DC143C
- **Cyan** = 0x0000FFFF
- **DarkBlue** = 0x0000008B
- **DarkCyan** = 0x00008B8B
- **DarkGoldenrod** = 0x00B8860B
- **DarkGray** = 0x00A9A9A9
- **DarkGreen** = 0x00006400
- **DarkKhaki** = 0x00BDB76B
- **DarkMagenta** = 0x008B008B
- **DarkOliveGreen** = 0x00556B2F
- **DarkOrange** = 0x00FF8C00
- **DarkOrchid** = 0x009932CC
- **DarkRed** = 0x008B0000
- **DarkSalmon** = 0x00E9967A
- **DarkSeaGreen** = 0x008FBC8F
- **DarkSlateBlue** = 0x00483D8B
- **DarkSlateGray** = 0x002F4F4F
- **DarkTurquoise** = 0x0000CED1
- **DarkViolet** = 0x009400D3
- **DeepPink** = 0x00FF1493
- **DeepSkyBlue** = 0x0000BFFF
- **DimGray** = 0x00696969
- **DodgerBlue** = 0x001E90FF
- **Firebrick** = 0x00B22222
- **FloralWhite** = 0x00FFFAF0
- **ForestGreen** = 0x00228B22
- **Fuchsia** = 0x00FF00FF
- **Gainsboro** = 0x00DCDCDC
- **GhostWhite** = 0x00F8F8FF
- **Gold** = 0x00FFD700
- **Goldenrod** = 0x00DAA520
- **Gray** = 0x00808080
- **Green** = 0x00008000
- **GreenYellow** = 0x00ADFF2F
- **Honeydew** = 0x00F0FFF0
- **HotPink** = 0x00FF69B4
- **IndianRed** = 0x00CD5C5C
- **Indigo** = 0x004B0082
- **Ivory** = 0x00FFFFF0
- **Khaki** = 0x00F0E68C
- **Lavender** = 0x00E6E6FA
- **LavenderBlush** = 0x00FFF0F5
- **LawnGreen** = 0x007CFC00
- **LemonChiffon** = 0x00FFFACD
- **LightBlue** = 0x00ADD8E6
- **LightCoral** = 0x00F08080
- **LightCyan** = 0x00E0FFFF
- **LightGoldenrodYellow** = 0x00FAFAD2
- **LightGray** = 0x00D3D3D3
- **LightGreen** = 0x0090EE90
- **LightPink** = 0x00FFB6C1
- **LightSalmon** = 0x00FFA07A
- **LightSeaGreen** = 0x0020B2AA
- **LightSkyBlue** = 0x0087CEFA
- **LightSlateGray** = 0x00778899
- **LightSteelBlue** = 0x00B0C4DE
- **LightYellow** = 0x00FFFFE0
- **Lime** = 0x0000FF00
- **LimeGreen** = 0x0032CD32
- **Linen** = 0x00FAF0E6
- **Magenta** = 0x00FF00FF
- **Maroon** = 0x00800000
- **MediumAquamarine** = 0x0066CDAA
- **MediumBlue** = 0x000000CD
- **MediumOrchid** = 0x00BA55D3
- **MediumPurple** = 0x009370DB
- **MediumSeaGreen** = 0x003CB371
- **MediumSlateBlue** = 0x007B68EE
- **MediumSpringGreen** = 0x0000FA9A
- **MediumTurquoise** = 0x0048D1CC
- **MediumVioletRed** = 0x00C71585
- **MidnightBlue** = 0x00191970
- **MintCream** = 0x00F5FFFA
- **MistyRose** = 0x00FFE4E1
- **Moccasin** = 0x00FFE4B5
- **NavajoWhite** = 0x00FFDEAD
- **Navy** = 0x00000080
- **OldLace** = 0x00FDF5E6
- **Olive** = 0x00808000
- **OliveDrab** = 0x006B8E23
- **Orange** = 0x00FFA500
- **OrangeRed** = 0x00FF4500
- **Orchid** = 0x00DA70D6
- **PaleGoldenrod** = 0x00EEE8AA
- **PaleGreen** = 0x0098FB98
- **PaleTurquoise** = 0x00AFEEEE
- **PaleVioletRed** = 0x00DB7093
- **PapayaWhip** = 0x00FFEFD5
- **PeachPuff** = 0x00FFDAB9
- **Peru** = 0x00CD853F
- **Pink** = 0x00FFC0CB
- **Plum** = 0x00DDA0DD
- **PowderBlue** = 0x00B0E0E6
- **Purple** = 0x00800080
- **Red** = 0x00FF0000
- **RosyBrown** = 0x00BC8F8F
- **RoyalBlue** = 0x004169E1
- **SaddleBrown** = 0x008B4513
- **Salmon** = 0x00FA8072
- **SandyBrown** = 0x00F4A460
- **SeaGreen** = 0x002E8B57
- **SeaShell** = 0x00FFF5EE
- **Sienna** = 0x00A0522D
- **Silver** = 0x00C0C0C0
- **SkyBlue** = 0x0087CEEB
- **SlateBlue** = 0x006A5ACD
- **SlateGray** = 0x00708090
- **Snow** = 0x00FFFAFA
- **SpringGreen** = 0x0000FF7F
- **SteelBlue** = 0x004682B4
- **Tan** = 0x00D2B48C
- **Teal** = 0x00008080
- **Thistle** = 0x00D8BFD8
- **Tomato** = 0x00FF6347
- **Turquoise** = 0x0040E0D0
- **Violet** = 0x00EE82EE
- **Wheat** = 0x00F5DEB3
- **White** = 0x00FFFFFF
- **WhiteSmoke** = 0x00F5F5F5
- **Yellow** = 0x00FFFF00
- **YellowGreen** = 0x009ACD32
- **Transparent** = 0xFFFFFFFF  
- **Auto** = 0xFF000000

All preset colors are defined with their corresponding ARGB hexadecimal values, 
with the alpha channel set to 0x00 (fully opaque). 
The two exceptions are Transparent and Auto, which are defined with their ARGB hexadecimal values 
that include the alpha channel set to 0xFF (fully transparent).
Transparent is defined as white with 100% alpha (0xFFFFFFFF) 
and Auto is defined as black with 100% alpha (0xFF000000).

## Drawings.SystemColor class

The **Drawings.SystemColor** class represents a color that is defined by the system colors of the operating system.
It has the following properties:
- **Index** - A property that holds the enumeration index to the system color table.
- **LastColor** - An optional property that holds the last color value used for this system color. This can be used to preserve the color value when the system color changes.
- **Tint** - An optional property that represents the tint of the color. It is a percentage value that can be used to lighten the color. A value of 0% means no change, while a value of 100% means the color is completely white (lightened).
- **Shade** - An optional property that represents the shade of the color. It is a percentage value that can be used to darken the color. A value of 0% means no change, while a value of 100% means the color is completely black (darkened).

The **Drawings.SystemColors** enumeration defines the following standard system color names that can be used as values for the Index property of the **Drawings.SystemColor** class:
-  **ScrollBar**
-  **Background**
-  **ActiveCaption**
-  **InactiveCaption**
-  **Menu**
-  **Window**
-  **WindowFrame**
-  **MenuText**
-  **WindowText**
-  **CaptionText**
-  **ActiveBorder**
-  **InactiveBorder**
-  **ApplicationWorkspace**
-  **Highlight**
-  **HighlightText**
-  **ButtonFace**
-  **ButtonShadow**
-  **GrayText**
-  **ButtonText**
-  **InactiveCaptionText**
-  **ButtonHighlight**
-  **ThreeDDarkShadow**
-  **ThreeDLight**
-  **InfoText**
-  **InfoBack**
-  **HotLight**
-  **GradientActiveCaption**
-  **GradientInactiveCaption**
-  **MenuHighlight**
-  **MenuBar**

All the names are self-explanatory and correspond to the standard system colors defined by the Windows operating system.

The **Drawings.SystemColor.LastColor** property serves multiple important purposes:
- **Cross-platform compatibility** - Provides a concrete color value when viewing documents on non-Windows systems
- **Fallback rendering** - Used when the system color cannot be resolved (e.g., in print preview, PDF export)
- **Document portability** - Ensures consistent appearance when the document is moved between systems
- **Color caching** - Stores the resolved color to avoid repeated OS queries

Applications typically update this property when:
- The document is first opened and system colors are resolved
- The user changes their Windows theme or high contrast settings
- The document is saved (to preserve the current color values)
- The document is rendered for export (PDF, image, etc.)

When rendering a document, applications should prefer the live system color (via **Index**) 
but fall back to **LastColor** if the system color cannot be resolved.
This ensures the best possible appearance in all environments while maintaining a reasonable
fallback for non-Windows or incompatible systems.



