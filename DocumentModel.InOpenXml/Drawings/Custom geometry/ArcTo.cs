namespace DocumentModel.Drawings;

/// <summary>
///   Represents an arc path command that draws an elliptical arc from the current point to a new point.
/// </summary>
/// <remarks>
///   <para>
///   The ArcTo command draws an elliptical arc by specifying the radii of the ellipse, 
///   the starting angle, and the angle through which to sweep (swing angle).
///   </para>
///   <para>
///   This corresponds to the DrawingML arcTo path command used in custom shapes and geometries.
///   The arc is drawn as a portion of an ellipse, where the ellipse is defined by horizontal 
///   and vertical radii (WidthRadius and HeightRadius), and the arc portion is defined by 
///   StartAngle and SwingAngle.
///   </para>
///   <para>
///   All angle values are expressed in 60,000ths of a degree (e.g., 90° = 5,400,000).
///   All distance values are expressed as shape coordinate units which are relative to the shape's width and height.
///   </para>
/// </remarks>
public class ArcTo: ModelElement<DXD.ArcTo>
{
  /// <summary>
  ///   Horizontal radius (width) of the ellipse from which the arc is drawn.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the horizontal radius of the ellipse in shape coordinate units.
  ///   Shape coordinates are relative to the shape's width, where the full width typically equals a value
  ///   defined in the shape's coordinate system (commonly using formulas or EMUs).
  ///   </para>
  ///   <para>
  ///   The value can be specified as:
  ///   <list type="bullet">
  ///     <item><description>A numeric string representing the radius value</description></item>
  ///     <item><description>A formula expression that evaluates to the radius</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The width radius, combined with HeightRadius, defines the ellipse shape from which 
  ///   the arc segment is extracted. Equal width and height radii produce a circular arc.
  ///   </para>
  /// </remarks>
  public string? WidthRadius { get; set; }

  /// <summary>
  ///   Vertical radius (height) of the ellipse from which the arc is drawn.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the vertical radius of the ellipse in shape coordinate units.
  ///   Shape coordinates are relative to the shape's height, where the full height typically equals a value
  ///   defined in the shape's coordinate system (commonly using formulas or EMUs).
  ///   </para>
  ///   <para>
  ///   The value can be specified as:
  ///   <list type="bullet">
  ///     <item><description>A numeric string representing the radius value</description></item>
  ///     <item><description>A formula expression that evaluates to the radius</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The height radius, combined with WidthRadius, defines the ellipse shape from which 
  ///   the arc segment is extracted. Equal width and height radii produce a circular arc.
  ///   </para>
  /// </remarks>
  public string? HeightRadius { get; set; }

  /// <summary>
  ///   Starting angle of the arc on the ellipse.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies where on the ellipse the arc begins, measured in 60,000ths of a degree.
  ///   The angle is measured clockwise from the 3 o'clock position (positive x-axis).
  ///   </para>
  ///   <para>
  ///   Common angle values:
  ///   <list type="bullet">
  ///     <item><description>0° (0) - 3 o'clock position (right)</description></item>
  ///     <item><description>90° (5,400,000) - 6 o'clock position (bottom)</description></item>
  ///     <item><description>180° (10,800,000) - 9 o'clock position (left)</description></item>
  ///     <item><description>270° (16,200,000) - 12 o'clock position (top)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The value can be specified as:
  ///   <list type="bullet">
  ///     <item><description>A numeric string in 60,000ths of a degree</description></item>
  ///     <item><description>A formula expression that evaluates to the angle</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   This angle determines the starting point of the arc on the ellipse's perimeter.
  ///   The arc is then drawn from this starting point through the angle specified by SwingAngle.
  ///   </para>
  /// </remarks>
  public string? StartAngle { get; set; }

  /// <summary>
  ///   Angular extent through which the arc sweeps.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies how far the arc travels along the ellipse from the starting point,
  ///   measured in 60,000ths of a degree. The arc sweeps clockwise from the StartAngle.
  ///   </para>
  ///   <para>
  ///   The swing angle determines the length of the arc:
  ///   <list type="bullet">
  ///     <item><description>Positive values sweep clockwise</description></item>
  ///     <item><description>90° (5,400,000) creates a quarter arc</description></item>
  ///     <item><description>180° (10,800,000) creates a half arc (semicircle)</description></item>
  ///     <item><description>270° (16,200,000) creates a three-quarter arc</description></item>
  ///     <item><description>360° (21,600,000) creates a full ellipse</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The value can be specified as:
  ///   <list type="bullet">
  ///     <item><description>A numeric string in 60,000ths of a degree</description></item>
  ///     <item><description>A formula expression that evaluates to the angle</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The endpoint of the arc is calculated by adding SwingAngle to StartAngle.
  ///   The arc is drawn along the ellipse's perimeter from the starting point to this endpoint.
  ///   </para>
  /// </remarks>
  public string? SwingAngle { get; set; }
}