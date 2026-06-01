using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange?view=office-pia"/>
public partial class ShapeRange
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.item?view=office-pia"/>
  public Shape Item(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Align`.
  /// </summary>
  /// <param name="AlignCmd">The `AlignCmd` parameter.</param>
  /// <param name="RelativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.align?view=office-pia"/>
  public void Align(AlignCmd AlignCmd, TriState RelativeTo) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Apply`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.apply?view=office-pia"/>
  public void Apply() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Distribute`.
  /// </summary>
  /// <param name="DistributeCmd">The `DistributeCmd` parameter.</param>
  /// <param name="RelativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.distribute?view=office-pia"/>
  public void Distribute(DistributeCmd DistributeCmd, TriState RelativeTo) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Duplicate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.duplicate?view=office-pia"/>
  public ShapeRange Duplicate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Flip`.
  /// </summary>
  /// <param name="FlipCmd">The `FlipCmd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.flip?view=office-pia"/>
  public void Flip(FlipCmd FlipCmd) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementleft?view=office-pia"/>
  public void IncrementLeft(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotation`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementrotation?view=office-pia"/>
  public void IncrementRotation(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementtop?view=office-pia"/>
  public void IncrementTop(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Group`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.group?view=office-pia"/>
  public Shape Group() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PickUp`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pickup?view=office-pia"/>
  public void PickUp() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Regroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.regroup?view=office-pia"/>
  public Shape Regroup() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RerouteConnections`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rerouteconnections?view=office-pia"/>
  public void RerouteConnections() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ScaleHeight`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scaleheight?view=office-pia"/>
  public void ScaleHeight
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ScaleWidth`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scalewidth?view=office-pia"/>
  public void ScaleWidth
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.select?view=office-pia"/>
  public void Select(object Replace) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetShapesDefaultProperties`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.setshapesdefaultproperties?view=office-pia"/>
  public void SetShapesDefaultProperties() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Ungroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.ungroup?view=office-pia"/>
  public ShapeRange Ungroup() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ZOrder`.
  /// </summary>
  /// <param name="ZOrderCmd">The `ZOrderCmd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.zorder?view=office-pia"/>
  public void ZOrder(ZOrderCmd ZOrderCmd) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropleft?view=office-pia"/>
  public void CanvasCropLeft(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascroptop?view=office-pia"/>
  public void CanvasCropTop(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropRight`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropright?view=office-pia"/>
  public void CanvasCropRight(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropBottom`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropbottom?view=office-pia"/>
  public void CanvasCropBottom(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.cut?view=office-pia"/>
  public void Cut() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.copy?view=office-pia"/>
  public void Copy() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `MergeShapes`.
  /// </summary>
  /// <param name="MergeCmd">The `MergeCmd` parameter.</param>
  /// <param name="PrimaryShape">The `PrimaryShape` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.mergeshapes?view=office-pia"/>
  public void MergeShapes(MergeCmd MergeCmd, Shape PrimaryShape) { throw new NotImplementedException(); }
}

