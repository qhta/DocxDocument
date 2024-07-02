using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EntityFrameworkCore.Jet;
using System.Xml.Linq;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Access.Dao;
using Microsoft.Office.Interop.Access;
using Dao = Microsoft.Office.Interop.Access.Dao;
using Access = Microsoft.Office.Interop.Access;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ModelXmlSchema;

public sealed class XmlSchemaDbContext : DbContext
{
  public DbSet<SchemaFile> SchemaFiles { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<UsedNamespace> UsedNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Pattern> Patterns { get; set; }

  public DbSet<UnionMember> UnionMembers { get; set; }

  public DbSet<ListItem> ListItems { get; set; }

  public DbSet<AttributeDef> Attributes { get; set; }

  public DbSet<AttributeGroup> AttributeGroups { get; set; }

  public DbSet<AttributeGroupRef> AttributeGroupRefs { get; set; }

  public DbSet<Particle> Particles { get; set; }

  public DbSet<Group> Groups { get; set; }

  public Elements Elements
  {
    get
    {
      if (_Elements == null)
      {
        _Elements = new Elements(Particles);
      }

      return _Elements;
    }
  }
  private Elements? _Elements;

  public Dictionary<string, SchemaFile> FilesDictionary { get; set; } = null!;

  public Dictionary<string, Namespace> NamespacesDictionary { get; set; } = null!;

  public GroupRefs SchemaGroupRefs
  {
    get
    {
      if (_SchemaGroupRefs == null)
      {
        _SchemaGroupRefs = new GroupRefs(Particles);
      }

      return _SchemaGroupRefs;
    }
  }
  private GroupRefs? _SchemaGroupRefs;

  public string DbFilename { get; }

  public XmlSchemaDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
    SetupAccessDatabase();
  }

  public override void Dispose()
  {
    base.Dispose();
    KillMsAccess();
  }

  public override async ValueTask DisposeAsync()
  {
    // Perform async cleanup of managed resources here.
    // Note: There's no need to call GC.SuppressFinalize(this) with the async dispose pattern.

    await base.DisposeAsync();
    KillMsAccess();
  }

  internal void KillMsAccess()
  {
    foreach (var process in Process.GetProcessesByName("MSACCESS"))
    {
      process.Kill();
    }
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    //optionsBuilder.LogTo(message => Console.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UsedNamespace>()
      .HasKey(e => new { SchemaFileId = e.FileId, e.NamespaceId });

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaFile)
      .WithMany(e => e.UsedNamespaces)
      .HasForeignKey(e => e.FileId);

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaNamespace)
      .WithMany()
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasDiscriminator<bool>("IsComplex")
      .HasValue<SimpleType>(false)
      .HasValue<ComplexType>(true);

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.Namespace)
      .WithMany(owner => owner.Types)
      .HasForeignKey(item => item.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.BaseType)
      .WithMany()
      .HasForeignKey(e => e.BaseTypeId);

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Pattern>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.Patterns)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.UnionMembers)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<ListItem>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<AttributeDef>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerTypeId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeDef>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.GlobalAttributes)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeGroup>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.GlobalAttributeGroups)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<Particle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<Any>(ParticleType.Any)
      .HasValue<Element>(ParticleType.Element)
      .HasValue<GroupRef>(ParticleType.GroupRef)
      .HasValue<All>(ParticleType.All)
      .HasValue<Choice>(ParticleType.Choice)
      .HasValue<Sequence>(ParticleType.Sequence);

    modelBuilder.Entity<Element>()
      .Property(e => e.Name)
      .HasColumnName("Name");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefName)
      .HasColumnName("Name");

    modelBuilder.Entity<Element>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<Particle>()
      .HasOne(p => p.ParentComplexType)
      .WithMany()
      .HasForeignKey(p => p.ComplexTypeId)
      .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Particle>()
        .HasOne(p => p.ParentGroup)
        .WithMany() // Assuming SchemaGroup has a collection of Particles
        .HasForeignKey(p => p.GroupId)
        .OnDelete(DeleteBehavior.Restrict);

    //modelBuilder.Entity<SchemaGroup>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentComplexType)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentGroup)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);


    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentParticle)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

  }

  internal void SetupAccessDatabase()
  {
    var accessApp = new Access.Application();
    Dao.Database database = null!;
    try
    {
      accessApp.OpenCurrentDatabase(DbFilename, false);
      database = accessApp.CurrentDb();
      SetQuery(database, "TypesList", "SELECT Types.Id, [Prefix] & \":\" & [Types].[Name] AS ShortName\r\nFROM Namespaces INNER JOIN Types ON Namespaces.Id = Types.NamespaceId;");
      SetQuery(database, "NamespacesList", "SELECT Namespaces.Id, [Prefix] & \": \" & [Url] AS FullName\r\nFROM Namespaces;");
      SetLookup(database, "Types", "NamespaceId", "NamespacesList");
      SetLookup(database, "Types", "BaseTypeId", "TypesList");
      SetLookup(database, "EnumValues", "OwnerTypeId", "TypesList");
      SetLookup(database, "Patterns", "OwnerTypeId", "TypesList");
      SetLookup(database, "UnionMembers", "OwnerTypeId", "TypesList");
      SetLookup(database, "UnionMembers", "MemberTypeId", "TypesList");
      SetLookup(database, "ListItems", "OwnerTypeId", "TypesList");
      SetLookup(database, "ListItems", "MemberTypeId", "TypesList");
      CreateEnumLookupTable(database, "ContentTypes", typeof(ContentType));
      SetLookup(database, "Types", "ContentType", "ContentTypes");

      SetLookup(database, "Attributes", "OwnerTypeId", "TypesList");
      SetLookup(database, "Attributes", "OwnerNamespaceId", "NamespacesList");
      SetLookup(database, "AttributeGroups", "OwnerNamespaceId", "NamespacesList");
    }
    catch (Exception ex)
    {
      Debug.WriteLine($"An error occurred: {ex.Message}");
    }
    finally
    {
      if (database != null)
      {
        accessApp.CloseCurrentDatabase();
      }
      accessApp.Quit(AcQuitOption.acQuitSaveAll);
      Marshal.ReleaseComObject(accessApp);
      accessApp = null!;
      // For good measure, force a garbage collection
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }

  }

  internal void CreateEnumLookupTable(Access.Dao.Database database, string tableName, Type enumType)
  {
    if (!enumType.IsEnum)
    {
      throw new ArgumentException("Type must be an enum", nameof(enumType));
    }

    TableDef tableDef = null!;
    Recordset recordset = null!;

    try
    {
      tableDef = CreateLookupTable(database, tableName);
      foreach (var value in Enum.GetValues(enumType))
      {
        recordset = database.OpenRecordset(tableName);
        recordset.AddNew();
        recordset.Fields["Id"].Value = (byte)value;
        recordset.Fields["Name"].Value = value.ToString();
        recordset.Update();
        recordset.Close();
      }
    }
    catch (COMException)
    {
      // Handle the COM exception, e.g., log it or show a message to the user.
    }
    finally
    {
      // Ensure COM objects are released even if an exception occurs.
      if (recordset != null) Marshal.ReleaseComObject(recordset);
      /*if (tableDef != null)*/
      Marshal.ReleaseComObject(tableDef);

      // For good measure, force a garbage collection.
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
  }

  internal TableDef CreateLookupTable(Access.Dao.Database database, string tableName)
  {
    TableDef tableDef = null!;
    Field idField = null!;
    Field nameField = null!;
    Dao.Index pkIndex = null!;
    try
    {
      tableDef = database.CreateTableDef(tableName);
      idField = tableDef.CreateField("Id", DataTypeEnum.dbByte);
      tableDef.Fields.Append(idField);
      nameField = tableDef.CreateField("Name", DataTypeEnum.dbText, 25);
      tableDef.Fields.Append(nameField);
      database.TableDefs.Append(tableDef);
      // Create a primary key index
      pkIndex = tableDef.CreateIndex("PrimaryKey");
      pkIndex.Primary = true; // Set as primary key
      pkIndex.Unique = true; // Ensure unique values

      // Add the ID field to the index
      Field indexField = pkIndex.CreateField("Id");
      (pkIndex.Fields as IndexFields)?.Append(indexField);

      // Append the Index to the TableDef
      tableDef.Indexes.Append(pkIndex);
    }
    catch (COMException comEx)
    {
      // Handle the COM exception, e.g., log it or show a message to the user.
      Debug.WriteLine($"COMException occurred: {comEx.Message}");
    }
    finally
    {
      // Ensure COM objects are released even if an exception occurs.
      if (pkIndex != null) Marshal.ReleaseComObject(pkIndex);
      if (nameField != null) Marshal.ReleaseComObject(nameField);
      if (idField != null) Marshal.ReleaseComObject(idField);
      if (tableDef != null) Marshal.ReleaseComObject(tableDef);

      // For good measure, force a garbage collection.
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
    return database.TableDefs[tableName];
  }

  internal void SetQuery(Access.Dao.Database database, string queryName, string sqlText)
  {
    QueryDef query = null!;
    try
    {
      query = database.CreateQueryDef(queryName, sqlText);
    }
    catch (COMException comEx)
    {
      // Handle the COM exception, e.g., log it or show a message to the user.
      Debug.WriteLine($"COMException occurred: {comEx.Message}");
    }
    finally
    {
      // Ensure COM objects are released even if an exception occurs.
      if (query != null) Marshal.ReleaseComObject(query);

      // For good measure, force a garbage collection.
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
  }

  internal void SetLookup(Access.Dao.Database database, string tableName, string fieldName, string lookupTableName)
  {
    var field = database.TableDefs[tableName].Fields[fieldName];
    SetProperty(field, "DisplayControl", DataTypeEnum.dbInteger, 111); // acComboBox
    SetProperty(field, "RowSourceType", DataTypeEnum.dbText, "Table/Query");
    SetProperty(field, "RowSource", DataTypeEnum.dbText, lookupTableName);
    SetProperty(field, "ColumnCount", DataTypeEnum.dbInteger, 2);
    SetProperty(field, "ColumnWidths", DataTypeEnum.dbText, "0");
  }

  internal void SetProperty(Access.Dao.Field field, string propertyName, DataTypeEnum dataType, object value)
  {
    Dao.Property prop = null!;

    try
    {
      // Try to access the property if it already exists
      prop = field.Properties[propertyName];
      prop.Value = value;
    }
    catch (System.Runtime.InteropServices.COMException)
    {
      Dao.Property newProp = null!;
      try
      {
        // If the property does not exist, create and append it
        newProp = field.CreateProperty(propertyName, dataType, value);
        field.Properties.Append(newProp);
      }
      catch (COMException comEx)
      {
        // Handle the COM exception, e.g., log it or show a message to the user.
        Debug.WriteLine($"COMException occurred: {comEx.Message}");
      }
      finally
      {
        // Ensure COM objects are released even if an exception occurs.
        if (newProp != null) Marshal.ReleaseComObject(newProp);
      }

    }
    finally
    {
      // Ensure COM objects are released even if an exception occurs.
      if (prop != null) Marshal.ReleaseComObject(prop);

      // For good measure, force a garbage collection.
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
  }

  public void LoadFiles()
  {
    FilesDictionary = SchemaFiles.ToDictionary(file => file.FileName);
    NamespacesDictionary = Namespaces.ToDictionary(ns => ns.Url ?? "");

    SchemaFiles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (SchemaFile file in args.NewItems!)
        {
          FilesDictionary.Add(file.FileName, file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespacesDictionary.Add(ns.Url, ns);
        }
      }
    };
  }

  public void LoadNamespaces()
  {
    //DisplayMessageEnabled = true;
    foreach (var ns in Namespaces
               .Include(ns => ns.Types)
            )
    {
      ns.TypesDictionary = ns.Types.ToDictionary(type => type.Name, type => type);
    }
    Types.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (TypeDef type in args.NewItems!)
        {
          NamespacesDictionary[type.Namespace.Url].TypesDictionary.TryAdd(type.Name, type);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.Patterns))
    {
      simpleType.PatternsDictionary = simpleType.Patterns.ToDictionary(pattern => pattern.Value);
    }
    Patterns.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Pattern pattern in args.NewItems!)
        {
          pattern.OwnerType.PatternsDictionary.TryAdd(pattern.Value, pattern);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.EnumValues))
    {
      simpleType.EnumValuesDictionary = simpleType.EnumValues.ToDictionary(enumValue => enumValue.Name);
    }
    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          enumValue.OwnerType.EnumValuesDictionary.TryAdd(enumValue.Name, enumValue);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.UnionMembers))
    {
      simpleType.UnionMembersDictionary = simpleType.UnionMembers
        .ToDictionary(unionMember => unionMember.MemberType.FullName);
    }
    UnionMembers.Local.CollectionChanged += (sender, args) =>
       {
         if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
         {
           foreach (UnionMember unionMember in args.NewItems!)
           {
             unionMember.OwnerType.UnionMembersDictionary.TryAdd(unionMember.MemberType.FullName, unionMember);
           }
         }
       };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.ListItems))
    {
      simpleType.ListItemsDictionary = simpleType.ListItems
        .ToDictionary(ListItem => ListItem.MemberType.FullName);
    }
    ListItems.Local.CollectionChanged += (sender, args) =>
       {
         if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
         {
           foreach (ListItem listItem in args.NewItems!)
           {
             listItem.OwnerType.ListItemsDictionary.TryAdd(listItem.MemberType.FullName, listItem);
           }
         }
       };



    foreach (var ns in Namespaces
               .Include(ns => ns.GlobalAttributes)
            )
    {
      ns.AttributesDictionary = ns.GlobalAttributes.ToDictionary(attribute => attribute.Name, attribute => attribute);
    }

    foreach (var ns in Namespaces
               .Include(ns => ns.GlobalAttributeGroups)
            )
    {
      ns.AttributeGroupsDictionary = ns.GlobalAttributeGroups.ToDictionary(attribute => attribute.Name, attribute => attribute);
    }

    foreach (var complexType in Types.OfType<ComplexType>().Include(type => type.Attributes))
    {
      if (complexType.Attributes != null)
        complexType.AttributesDictionary = complexType.Attributes
          .ToDictionary(attribute => attribute.Name);
    }
    Attributes.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (AttributeDef attribute in args.NewItems!)
        {
          if (attribute.OwnerType != null)
          {
            attribute.OwnerType.AttributesDictionary.TryAdd(attribute.Name, attribute);
          }
          else if (attribute.OwnerNamespace != null)
          {
            attribute.OwnerNamespace.AttributesDictionary.TryAdd(attribute.Name, attribute);
          }
        }
      }
    };

  }
}
