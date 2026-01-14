namespace DocumentModel.Drawings;

/// <summary>
///   Represents a 3D anchor point that defines a position in three-dimensional space.
/// </summary>
/// <remarks>
///   <para>
///   The Anchor defines a fixed point in 3D space using Cartesian coordinates (X, Y, Z).
///   This is commonly used in DrawingML for positioning 3D shapes, cameras, lights, 
///   and other 3D scene elements.
///   </para>
///   <para>
///   In DrawingML 3D scenes, the anchor point serves as:
///   <list type="bullet">
///     <item><description>The origin point for 3D transformations</description></item>
///     <item><description>The reference point for camera positioning</description></item>
///     <item><description>The attachment point for 3D shapes and objects</description></item>
///     <item><description>The pivot point for rotations in 3D space</description></item>
///   </list>
///   </para>
///   <para>
///   All coordinate values are expressed in EMUs (English Metric Units), where:
///   <list type="bullet">
///     <item><description>1 EMU = 1/914,400 inch</description></item>
///     <item><description>1 EMU = 1/36,000 millimeter</description></item>
///     <item><description>914,400 EMUs = 1 inch</description></item>
///     <item><description>36,000 EMUs = 1 millimeter</description></item>
///   </list>
///   </para>
///   <para>
///   The coordinate system follows the standard 3D Cartesian convention:
///   <list type="bullet">
///     <item><description>+X axis points to the right</description></item>
///     <item><description>+Y axis points downward (in most DrawingML contexts)</description></item>
///     <item><description>+Z axis points toward the viewer (out of the screen)</description></item>
///   </list>
///   </para>
/// </remarks>
public class Anchor: ModelElement
{
  /// <summary>
  ///   X-coordinate (horizontal position) of the anchor point in 3D space.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the horizontal position along the X-axis in EMUs (English Metric Units).
  ///   In the standard 3D coordinate system, positive X values extend to the right,
  ///   and negative X values extend to the left.
  ///   </para>
  ///   <para>
  ///   The X-coordinate is measured from the origin (0, 0, 0) of the 3D scene.
  ///   When used in camera positioning, this represents the horizontal position of the camera
  ///   or the point the camera is looking at.
  ///   </para>
  ///   <para>
  ///   Common usage examples:
  ///   <list type="bullet">
  ///     <item><description>0 - Center position on the X-axis</description></item>
  ///     <item><description>Positive values - Right side of center</description></item>
  ///     <item><description>Negative values - Left side of center</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   To convert from common units to EMUs:
  ///   <list type="bullet">
  ///     <item><description>Inches to EMUs: multiply by 914,400</description></item>
  ///     <item><description>Millimeters to EMUs: multiply by 36,000</description></item>
  ///     <item><description>Points to EMUs: multiply by 12,700</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-coordinate (vertical position) of the anchor point in 3D space.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the vertical position along the Y-axis in EMUs (English Metric Units).
  ///   In DrawingML's 3D coordinate system, positive Y values typically extend downward,
  ///   and negative Y values extend upward (following screen coordinate conventions).
  ///   </para>
  ///   <para>
  ///   The Y-coordinate is measured from the origin (0, 0, 0) of the 3D scene.
  ///   When used in camera positioning, this represents the vertical position of the camera
  ///   or the vertical component of the look-at point.
  ///   </para>
  ///   <para>
  ///   Common usage examples:
  ///   <list type="bullet">
  ///     <item><description>0 - Center position on the Y-axis</description></item>
  ///     <item><description>Positive values - Below center (downward in most contexts)</description></item>
  ///     <item><description>Negative values - Above center (upward in most contexts)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Note: The Y-axis direction may vary depending on the specific DrawingML context.
  ///   In some 3D modeling contexts, +Y points upward (standard mathematical convention),
  ///   but in screen-based contexts, +Y typically points downward.
  ///   </para>
  /// </remarks>
  public Int64? Y { get; set; }

  /// <summary>
  ///   Z-coordinate (depth position) of the anchor point in 3D space.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the depth position along the Z-axis in EMUs (English Metric Units).
  ///   In the standard 3D coordinate system, positive Z values extend toward the viewer
  ///   (out of the screen), and negative Z values extend away from the viewer (into the screen).
  ///   </para>
  ///   <para>
  ///   The Z-coordinate is measured from the origin (0, 0, 0) of the 3D scene.
  ///   This dimension is critical for creating depth perception in 3D visualizations.
  ///   When used in camera positioning, this represents the distance of the camera from
  ///   the viewing plane or the depth of the look-at point.
  ///   </para>
  ///   <para>
  ///   Common usage examples:
  ///   <list type="bullet">
  ///     <item><description>0 - Position on the viewing plane</description></item>
  ///     <item><description>Positive values - Closer to the viewer (forward)</description></item>
  ///     <item><description>Negative values - Farther from the viewer (backward)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The Z-coordinate is essential for:
  ///   <list type="bullet">
  ///     <item><description>Depth sorting and occlusion (which objects appear in front)</description></item>
  ///     <item><description>3D transformations and rotations</description></item>
  ///     <item><description>Camera positioning and field of view calculations</description></item>
  ///     <item><description>Lighting effects and shadows in 3D scenes</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public Int64? Z { get; set; }
}