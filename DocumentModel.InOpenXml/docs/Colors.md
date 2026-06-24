OpenXml SDK provides a set of classes to represent colors in different color models, including RGB, HSL, scheme colors, system colors, and preset colors. 

# OpenXml color classes

Most of OpenXml color classes are located in the **DocumentFormat.OpenXml.Drawing** namespace, while some are in the **DocumentFormat.OpenXml.Wordprocessing** namespace.
The classes are as follows:
- **Drawing.ColorType** - represents an OpenXmlCompositeElement that can contain one of six color models in DrawingsML:
	1. **Drawing.RgbColorModelHex** - RGB color in hexadecimal model
	2. **Drawing.RgbColorModelPercentage** - RGB color in percentage model
	3. **Drawing.HslColorModel** - HSL color in percentage model
	4. **Drawing.SystemColor** - system color
	5. **Drawing.PresetColor** - preset color
	6. **Drawing.SchemeColor** - scheme color
- **Wordprocessing.Color** - it is an OpenXmlLeafElement that represents a color in WordprocessingML, widely used for text and shading colors.
- **Office2010.Word.RgbColorModelHex** - RGB color in hexadecimal model, used in WordprocessingML, closely mimicking the DrawingsML RGBColorModelHex class.
- **Office2010.Word.SchemeColor** - scheme color, used in WordprocessingML, closely mimicking the DrawingsML SchemeColor class.

## DrawingModel.ColorType definition classes

The six available ColorType components define various color models in the following classes.

### RgbColorModelHex class

The **Drawing.RgbColorModelHex** class represents a color in the RGB color model using hexadecimal notation. 
The **Val** property has the format "RRGGBB", where RR, GG, and BB are two-digit hexadecimal numbers representing the red, green, and blue components of the color, respectively.

### RgbColorModelPercentage class

The **Drawing.RgbColorModelPercentage** class represents a color in the RGB color model using percentage notation.
Three properties **RedPortion**, **GreenPortion**, and **BluePortion** represent the red, green, and blue components of the color, respectively. 
The values are of Int32 type and are in the range from 0 to 100,000, where 0 means no contribution of that color component and 100,000 means full (100%) contribution of that color component.

### HslColorModel class

The **Drawing.HslColorModel** class represents a color in the HSL color model using degree and percentage notation.
The **HueValue** property is a degree value that ranges from 0 to 360 degrees, where 0 degree represents red, 120 degrees represents green, and 240 degrees represents blue. 
The value of hue is stored as an Int32 type in the range from 0 to 21,600,000, where 1 degree is represented as 60,000 units.

The **SatValue** and **LumValue** properties are percentage values that represent the saturation and luminance components of the color, respectively.

### PresetColor class

The **Drawing.PresetColor** class represents a color using a predefined color name. 
The **Val** property is an enumeration of the standard preset color names, such as "AliceBlue", "AntiqueWhite", "Aqua", etc. A set of 190 preset color names and values is defined in the **Drawing.PresetColors** enumeration.

### SystemColor class

The **Drawing.SystemColor** class represents a color that is defined in the system color table of the operating system.
The **Val** property is an enumeration of the standard system color names, such as "ActiveBorder", "ActiveCaption", "AppWorkspace", etc. A set of 16 system color names is defined in the **Drawing.SystemColors** enumeration.	
The **LastColor** property is an optional property that represents the last color value used in the system color table. It is a hexadecimal RGB value in the format "RRGGBB".
It can be helpful when the document is viewed on a system with a different color scheme.

### SchemeColor class

The **Drawing.SchemeColor** class have a **Val** property, which is a **SchemeColorValues** enumeration of the standard themed colors, including 6 accent colors, 2 dark colors, 2 light colors, and 2 hyperlink colors.
The actual color values are defined in the **Drawing.ColorScheme** class, which is a part of the document theme.

### Drawing color transformation elements

All the drawing color classes can contain several optional elements that can be used to transform the color value. Classes of these elementsare the following:
- **Drawing.Alpha** - specifies that defined color has a specific opacity (as positive fixed percentage), but with its color unchanged.
- **Drawing.AlphaOffset** - specifies a more or less opaque version of its input color. Increases or decreases the input alpha percentage by the specified percentage offset. A 10% alpha offset increases a 50% opacity to 60%. A -10% alpha offset decreases a 50% opacity to 40%. The transformed alpha values are limited to a range of 0 to 100%. A 10% alpha offset increase to a 100% opaque object still results in 100% opacity.
- **Drawing.AlphaModulation** - specifies a more or less opaque version of its input color. An alpha modulate never increases the alpha beyond 100%. A 200% alpha modulate makes a input color twice as opaque as before. A 50% alpha modulate makes a input color half as opaque as before.
- **Drawing.Blue** - specifies the input color with the specific blue component, but with the red and green color components unchanged.
- **Drawing.BlueOffset** - specifies specifies the input color with its blue component shifted, but with its red and green color components unchanged.
- **Drawing.BlueModulation** - specifies the input color with its blue component modulated by the given percentage. A 50% blue modulate reduces the blue component by half. A 200% blue modulate doubles the blue component.
- **Drawing.Green** - specifies the input color with the specific green component, but with the red and blue color components unchanged.
- **Drawing.GreenOffset** - specifies the input color with its green component shifted, but with its red and blue color components unchanged.
- **Drawing.GreenModulation** - specifies the input color with its green component modulated by the given percentage. A 50% green modulate reduces the green component by half. A 200% green modulate doubles the green component.
- **Drawing.Red** - specifies the input color with the specific red component, but with the green and blue color components unchanged.
- **Drawing.RedOffset** - specifies the input color with its red component shifted, but with its green and blue color components unchanged.
- **Drawing.RedModulation** - specifies the input color with its red component modulated by the given percentage. A 50% red modulate reduces the red component by half. A 200% red modulate doubles the red component.
- **Drawing.Hue** - specifies the input color with the specific hue component, but with the saturation and luminance components unchanged.
- **Drawing.HueOffset** - specifies the input color with its hue component shifted, but with its saturation and luminance components unchanged.
- **Drawing.HueModulation** - specifies the input color with its hue component modulated by the given percentage. A 50% hue modulate reduces the hue component by half. A 200% hue modulate doubles the hue component.
- **Drawing.Saturation** - specifies the input color with the specific saturation component, but with the hue and luminance components unchanged.
- **Drawing.SaturationOffset** - specifies the input color with its saturation component shifted, but with its hue and luminance components unchanged.
- **Drawing.SaturationModulation** - specifies the input color with its saturation component modulated by the given percentage. A 50% saturation modulate reduces the saturation component by half. A 200% saturation modulate doubles the saturation component.
- **Drawing.Luminance** - specifies the input color with the specific luminance component, but with the hue and saturation components unchanged.
- **Drawing.LuminanceOffset** - specifies the input color with its luminance component shifted, but with its hue and saturation components unchanged.
- **Drawing.LuminanceModulation** - specifies the input color with its luminance component modulated by the given percentage. A 50% luminance modulate reduces the luminance component by half. A 200% luminance modulate doubles the luminance component.
- **Drawing.Tint** - specifies the input color with a tint applied. A tint is a percentage of white added to the color, lightening it. A 10% tint is 10% of the input color combined with 90% white.
- **Drawing.Shade** - specifies the input color with a shade applied. A shade is a percentage of black added to the color, darkening it. A 10% shade is 10% of the input color combined with 90% black.
- **Drawing.Complement** - specifies the input color with its complement (opposite) color applied. The complement color is the color directly opposite on the color wheel. For example, the complement of red is cyan, green is magenta, and blue is yellow.
- **Drawing.Inverse** - specifies the input color with its inverse color applied. The inverse color is calculated by inverting each RGB component (255 - value). For example, the inverse of red (255,0,0) is cyan (0,255,255).
- **Drawing.Gray** - specifies the input color with its grayscale version applied. The grayscale value is calculated based on the perceived luminance of the original color, resulting in a shade of gray that represents the brightness of the color.
- **Drawing.Gamma** - specifies the input color with gamma correction applied. Gamma correction adjusts the brightness of the color to account for the nonlinear response of display devices. A gamma value of 2.2 is commonly used for standard displays.
- **Drawing.InverseGamma** - specifies the input color with inverse gamma correction applied. Inverse gamma correction reverses the gamma correction process, converting display-corrected RGB values back to linear RGB values.

Note that:
1. The above color transformation elements can be combined in a single color definition to achieve complex color effects. The order of application of these transformations is important, as it can affect the final resulting color.
2. In the **Drawing.RgbColorModelPercentage**, the **Red**, **Green**, and **Blue** transformation elements are independent of the **RedPortion**, **GreenPortion**, and **BluePortion** properties. 
The **RedPortion**, **GreenPortion**, and **BluePortion** properties define the base color value, while the **Red**, **Green**, and **Blue** transformation elements can be used to modify the base color by applying additional adjustments.
3. Analogously, in the **Drawing.HslColorModel**, the **Hue**, **Saturation**, and **Luminance** transformation elements are independent of the **HueValue**, **SatValue**, and **LumValue** properties.

## Definition of themed colors

A **Drawing.Theme** class, stored in the document theme part, defines a color scheme that can be used throughout the document.
A **Drawing.ColorScheme** class defines 12 common colors that can be used in the whole document, including 6 accent colors, 2 dark colors, 2 light colors, and 2 hyperlink colors.
These colors are defined in the following classes:
- **Dark1Color**
- **Light1Color**
- **Dark2Color**
- **Light2Color**
- **Accent1Color**
- **Accent2Color**
- **Accent3Color**
- **Accent4Color**
- **Accent5Color**
- **Accent6Color**
- **HyperlinkColor**
- **FollowedHyperlinkColor**

The above scheme definition classes are derived from a **Color2Type** abstract class which can contain one of the five color models in DrawingsML:
1. **Drawing.RgbColorModelHex** - RGB color in hexadecimal model
2. **Drawing.RgbColorModelPercentage** - RGB color in percentage model
3. **Drawing.HslColorModel** - HSL color in percentage model
4. **Drawing.SystemColor** - system color
5. **Drawing.PresetColor** - preset color

Obviously, the **Drawing.SchemeColor** class can't be used in a **Color2Type** class.

## Using the drawing color classes

The **Drawing.ColorType**, which can contain the six above mentioned DrawingML specific color models, is a base class for the following specific classes:
- **Drawing.BackgroundColor** - represents a background color for a pattern fill.
- **Drawing.BulletColor** - specifies the color to be used on bullet characters within a given paragraph.
- **Drawing.ColorFrom** - specifies a color getting removed (source color) in a color change effect.
- **Drawing.ColorTo** - specifies a color getting applied (target color) in a color change effect.
- **Drawing.ContourColor** - represents a contour color for a shape or object.
- **Drawing.ExtrusionColor** - represents an extrusion color for a 3D shape.
- **Drawing.ForegroundColor** - represents a foreground color for a pattern fill.
- **Drawing.Highlight** - represents a highlight color for text or objects.

Moreover, the following classes in DrawingsML, although not derived from **Drawing.ColorType**, can also contain one of the six DrawingML specific color models:
- **Drawing.AlphaInverse** - represents an alpha inverse effect that can be applied to images in DrawingsML.
- **Drawing.ColorReplacement** - represents a solid color replacement effect that can be applied to images in DrawingsML.
- **Drawing.ColorTransform** - represents a color transformation effect that can be applied to images in DrawingsML.
- **Drawing.Duotone** - represents a duotone effect that can be applied to images in DrawingsML. The duotone effect uses two colors through a linear interpolation to create a two-tone image effect.
- **Drawing.Glow** - represents a glow effect that can be applied to shapes and text in DrawingsML.
- **Drawing.GradientStop** - represents a gradient stop, which defines a position of a color within a gradient fill.
- **Drawing.InnerShadow** - represents an inner shadow effect that can be applied within the edges of a shape or text in DrawingsML.
- **Drawing.OuterShadow** - represents an outer shadow effect that can be applied outside the edges of a shape or text in DrawingsML.
- **Drawing.PresetShadow** - represents a preset shadow effect that can be applied to shapes and text in DrawingsML.
- **Drawing.SolidFill** - represents a solid color fill that can be applied to shapes and text in DrawingsML.
- **Drawing.CustomColor** - represents a custom color that can be defined within a custom color list to define extra colors that can be appended to a theme. This is useful within corporate scenarios where there is a set corporate color palette from which to work.
- **Drawing.EffectReference** - represents a reference to an effect style within a style effect list while defining a color that can be applied to shapes and text in DrawingsML.
- **Drawing.FillReference** - represents a reference to a fill style within a fillstyle list while defining a fill style or background style that can be applied to shapes and text in DrawingsML.
- **Drawing.LineReference** - represents a reference to a line style within a fill style list while defining a color that can be applied to lines and borders in DrawingsML.
- **Drawing.FontReference** - represents a reference to a themed font style within a font theme while defining a color that can be applied to the font.
- **Drawing.TableCellTextStyle** - defines the text properties associated with the text contained within a table cell in DrawingML.

The same six DrawingML specific color model components can be also used in the Drawing.Diagrams classes:
- **Drawing.Diagrams.FillColorList** - specifies a list of colors to be used for fills in a diagram.
- **Drawing.Diagrams.LineColorList** - specifies a list of colors to be used for lines in a diagram.
- **Drawing.Diagrams.EffectColorList** - specifies a list of colors to be used for effects in a diagram.
- **Drawing.Diagrams.TextEffectColorList** - specifies a list of colors to be used for text effects in a diagram.
- **Drawing.Diagrams.TextFillColorList** - specifies a list of colors to be used for text fills in a diagram.
- **Drawing.Diagrams.TextLineColorList** - specifies a list of colors to be used for text lines in a diagram.

## Colors in WordprocessingML

The WordprocessingML defines three color models that can be used in text and shading colors.

Note that the WordprocessingML color model classes properties are expressed in percentage values, but with a different scale than the DrawingML color model classes.
The "100%" value in WordprocessingML color model classes is expressed as 100, while the "100%" value in DrawingML color model classes is expressed as 100,000.

### Wordprocessing.Color class

The **Wordprocessing.Color** class specifies colors with the following properties:
- **Val** - specifies the color value in hexadecimal format (RRGGBB).
- **ThemeColor** - specifies the color value based on a drawing theme defined color. 
- **ThemeTint** - specifies the tint of the theme color.
- **ThemeShade** - specifies the shade of the theme color.

A **Wordprocessing.ThemeColorValues** enumeration is wider than **Drawing.SchemeColorValues** enumeration having four additional colors:
- **Text1Color** - a WordprocessingML specific theme color that is not defined in the DrawingML scheme colors.
- **Background1Color** - a WordprocessingML specific theme color that is not defined in the DrawingML scheme colors.
- **Text2Color** - a WordprocessingML specific theme color that is not defined in the DrawingML scheme colors.
- **Background2Color** - a WordprocessingML specific theme color that is not defined in the DrawingML scheme colors.

The **ThemeTint** and **ThemeShade** properties are percentage values that can be used to lighten or darken the theme color, respectively.
They are expressed as two-digit hexadecimal numbers, where "00" means no change, "FF" means full tint (white), and "FF" means full shade (black).

### Office2010.Word.RgbColorModelHex class

The **Office2010.Word.RgbColorModelHex** class is a complex type that specifies a color using the RGB color model. 
Red, green, and blue are expressed as a sequence of hex digits, RRGGBB. 

### Office2010.Word.SchemeColor class

The **Office2010.Word.SchemeColor** class has a **Val** property, which is a **Office2010.Word.SchemeColorValues** enumeration of the standard themed colors.
It is similar to the **Wordprocessing.ThemeColorValues** class, but with addition of **AutoColor** value.

### Office2010.Word color transformation elements

Both **Office2010.Word.RgbColorModelHex** and **Office2010.Word.SchemeColor** types optionally specify a list of color transforms applied to the base color:
- **Tint** - specifies that defined color has a specific tint (as positive fixed percentage), but with its color unchanged.
- **Shade** - specifies that defined color has a specific shade (as positive fixed percentage), but with its color unchanged.
- **Alpha** - specifies that defined color has a specific opacity (as positive fixed percentage), but with its color unchanged.
- **HueModulation** - specifies that defined color has a specific hue modulation (as positive fixed percentage).A 50% hue modulate decreases the angular hue value by half. A 200% hue modulate doubles the angular hue value.
- **Saturation** - specifies that defined color has a specific saturationbut, with its hue and luminance unchanged.
- **SaturationOffset** - specifies that defined color has a specific saturation offset (as positive fixed percentage). A 10% saturation offset increases the saturation value by 10%. A -10% saturation offset decreases the saturation value by 10%.
- **SaturationModulation** - specifies that defined color has a specific saturation modulation (as positive fixed percentage). A 50% saturation modulate decreases the saturation value by half. A 200% saturation modulate doubles the saturation value.
- **Luminance** - specifies that defined color has a specific luminance, but with its hue and saturation unchanged.
- **LuminanceOffset** - specifies that defined color has a specific luminance offset (as positive fixed percentage). A 10% luminance offset increases the luminance value by 10%. A -10% luminance offset decreases the luminance value by 10%.
- **LuminanceModulation** - specifies that defined color has a specific luminance modulation (as positive fixed percentage). A 50% luminance modulate decreases the luminance value by half. A 200% luminance modulate doubles the luminance value.

# Specifying colors in the DocumentModel

DocumentModel reduces the complexity of color specification.

First, it defines universal Percentage and Degree types for all color properties, which are used in all color models, 
despite the source color class namespace.

## Percentage and Degree types

Most of color model class properties use two base types of values: **Percentage** and **Degree**.

## Drawings.Percentage class

All percentage values in the DocumentModel classes are represented by **Percentage** class, 
which stores the value as an integer value, where the value is scaled by 1000 to preserve precision. 
So, a value of 100% is represented internally as 100,000, a value of 50% is represented as 50,000, 
and a value of 0.5% is represented as 500.

The **Percentage** class supports implicit conversions to/from numeric types and string representations 
with an optional "%" suffix. Conversions from numeric types hides internal scaling, 
so that a value of 100% can be assigned as 100, and a value of 0.5% can be assigned as 0.5.

## Degree class

A **Hue** property in the HSL color model is represented by **Degree** class, 
which stores the value as an integer value, where the value is scaled by 60,000 to preserve precision.
So, a value of 180 degrees is represented internally as 10,800,000, a value of 0.5 degrees is represented as 30,000, and a value of 0.5 degrees is represented as 30,000.

This class supports implicit conversions to/from numeric types and string representations with an optional "°" suffix.
Conversions from numeric types hides internal scaling, 
so that a value of 180 degrees can be assigned as 180, and a value of 0.5 degrees can be assigned as 0.5.

## Drawings.DrawingsColorBase\<T> class

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



