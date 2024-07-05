using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Access;
using Microsoft.Office.Interop.Access.Dao;

using Access = Microsoft.Office.Interop.Access;
using Dao = Microsoft.Office.Interop.Access.Dao;

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

  public DbSet<AttributeBase> Attributes { get; set; }

  public DbSet<AttributeGroup> AttributeGroups { get; set; }

  public DbSet<Particle> Particles { get; set; }

  public DbSet<ElementGroup> ElementGroups { get; set; }

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

  public ElementGroupRefs SchemaGroupRefs
  {
    get
    {
      if (_SchemaGroupRefs == null)
      {
        _SchemaGroupRefs = new ElementGroupRefs(Particles);
      }

      return _SchemaGroupRefs;
    }
  }
  private ElementGroupRefs? _SchemaGroupRefs;

  public string DbFilename { get; }

  public XmlSchemaDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
    SetupAccessDatabase();
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
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.Types)
      .HasForeignKey(item => item.OwnerNamespaceId);

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

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerTypeId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerGroup)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerGroupId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasDiscriminator<AttributeType>("Type")
      .HasValue<AttributeDef>(AttributeType.AttributeDef)
      .HasValue<AttributeRef>(AttributeType.AttributeRef)
      .HasValue<AttributeGroupRef>(AttributeType.AttributeGroupRef);


    modelBuilder.Entity<AttributeGroup>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.AttributeGroups)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<Particle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<Any>(ParticleType.Any)
      .HasValue<Element>(ParticleType.Element)
      .HasValue<ElementGroupRef>(ParticleType.GroupRef)
      .HasValue<All>(ParticleType.All)
      .HasValue<Choice>(ParticleType.Choice)
      .HasValue<Sequence>(ParticleType.Sequence);

    //modelBuilder.Entity<Particle>()
    //  .HasOne(p => p.OwnerType)
    //  .WithOne(ct => ct.Particle)
    //  .HasForeignKey<Particle>(p => p.OwnerTypeId)
    //  .IsRequired(false);

    modelBuilder.Entity<ComplexType>()
      .HasOne(p => p.Particle)
      .WithOne(ct => ct.OwnerType)
      .HasForeignKey<ComplexType>(p => p.ParticleId)
      .IsRequired(false);

    modelBuilder.Entity<Particle>()
      .HasOne(p => p.OwnerParticle)
      .WithMany(g => g.Items)
      .HasForeignKey(p => p.OwnerParticleId)
      .IsRequired(false);

    modelBuilder.Entity<ElementGroup>()
      .HasOne(p => p.Particle)
      .WithOne(ct => ct.OwnerGroup)
      .HasForeignKey<ElementGroup>(p => p.ParticleId)
      .IsRequired(false);

    modelBuilder.Entity<Element>()
      .HasOne(e => e.RefElement)
      .WithMany()
      .HasForeignKey(e => e.RefElementId);

    modelBuilder.Entity<ElementGroup>()
      .HasOne(g => g.OwnerNamespace)
      .WithMany(g => g.ElementGroups)
      .HasForeignKey(p => p.OwnerNamespaceId);

    modelBuilder.Entity<Element>()
      .HasOne(g => g.OwnerNamespace)
      .WithMany(g => g.Elements)
      .HasForeignKey(p => p.OwnerNamespaceId);
  }

  internal void SetupAccessDatabase()
  {
    var accessApp = new Access.Application();
    Dao.Database database = null!;
    try
    {
      accessApp.OpenCurrentDatabase(DbFilename, false);
      database = accessApp.CurrentDb();
      SetQuery(database, "TypesList", "SELECT Types.Id, [Prefix] & \":\" & [Types].[Name] AS FullName\r\nFROM Namespaces INNER JOIN Types ON Namespaces.Id = Types.OwnerNamespaceId;");
      SetQuery(database, "AttributeGroupsList", "SELECT AttributeGroups.Id, [Prefix] & \":\" & [AttributeGroups].[Name] AS FullName\r\nFROM Namespaces INNER JOIN AttributeGroups ON Namespaces.Id = AttributeGroups.OwnerNamespaceId;");
      SetQuery(database, "NamespacesList", "SELECT Namespaces.Id, [Prefix] & \": \" & [Url] AS FullName\r\nFROM Namespaces;");
      SetQuery(database, "ElementGroupsList", "SELECT ElementGroups.Id, [Namespaces].[Prefix] & \":\" & [ElementGroups].[Name] AS FullName\r\nFROM Namespaces INNER JOIN ElementGroups ON Namespaces.Id = ElementGroups.OwnerNamespaceId;");

      //SetLookup(database, "Types", "OwnerNamespaceId", "NamespacesList");
      //SetLookup(database, "Types", "BaseTypeId", "TypesList");
      //SetLookup(database, "EnumValues", "OwnerTypeId", "TypesList");
      //SetLookup(database, "Patterns", "OwnerTypeId", "TypesList");
      //SetLookup(database, "UnionMembers", "OwnerTypeId", "TypesList");
      //SetLookup(database, "UnionMembers", "MemberTypeId", "TypesList");
      //SetLookup(database, "ListItems", "OwnerTypeId", "TypesList");
      //SetLookup(database, "ListItems", "MemberTypeId", "TypesList");

      CreateEnumLookupTable(database, "ContentTypes", typeof(ContentType));
      SetLookup(database, "Types", "ContentType", "ContentTypes");

      //SetLookup(database, "Attributes", "OwnerTypeId", "TypesList");
      //SetLookup(database, "Attributes", "OwnerGroupId", "AttributeGroupsList");
      //SetLookup(database, "Attributes", "OwnerNamespaceId", "NamespacesList");

      CreateEnumLookupTable(database, "AttributeTypes", typeof(AttributeType));
      SetLookup(database, "Attributes", "Type", "AttributeTypes");

      CreateEnumLookupTable(database, "ParticleTypes", typeof(ParticleType));
      SetLookup(database, "Particles", "ParticleType", "ParticleTypes");

      //SetLookup(database, "Particles", "OwnerNamespaceId", "NamespacesList");
      //SetLookup(database, "Particles", "OwnerTypeId", "TypesList");
      //SetLookup(database, "Particles", "OwnerGroupId", "ElementGroupsList");

      SetLookup(database, "ElementGroups", "OwnerNamespaceId", "NamespacesList");
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
      KillMsAccess();
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
        var n = (byte)value;
        recordset.Fields["Id"].Value = n;
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
          NamespacesDictionary[type.OwnerNamespace.Url].TypesDictionary.TryAdd(type.Name, type);
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

    foreach (var simpleType in Types.OfType<SimpleType>()
               .Include(type => type.UnionMembers)
               .ThenInclude(member => member.MemberType))
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
             try
             {
               unionMember.OwnerType.UnionMembersDictionary.TryAdd(unionMember.MemberType.FullName, unionMember);
             }
             catch (Exception e)
             {
               Console.WriteLine(e);
               throw;
             }
           }
         }
       };

    foreach (var simpleType in Types.OfType<SimpleType>()
               .Include(type => type.ListItems)
               .ThenInclude(item => item.MemberType))
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
               .Include(ns => ns.Attributes))
    {
      ns.AttributesDictionary = ns.Attributes.ToDictionary(attribute => attribute.FullName, attribute => attribute);
    }

    foreach (var ns in Namespaces
               .Include(ns => ns.AttributeGroups))
    {
      ns.AttributeGroupsDictionary = ns.AttributeGroups.ToDictionary(attributeGroup => attributeGroup.FullName, attributeGroup => attributeGroup);
    }
    AttributeGroups.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (AttributeGroup group in args.NewItems!)
        {
          group.OwnerNamespace.AttributeGroupsDictionary.TryAdd(group.FullName, group);
        }
      }
    };

    foreach (var attributeGroup in AttributeGroups
               .Include(group => group.Attributes))
    {
      attributeGroup.AttributesDictionary = attributeGroup.Attributes.ToDictionary(attribute => attribute.FullName, attribute => attribute);
    }

    foreach (var complexType in Types.OfType<ComplexType>()
               .Include(type => type.Attributes))
    {
      complexType.AttributesDictionary = complexType.Attributes
        .ToDictionary(attribute => attribute.FullName);
    }
    Attributes.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (AttributeBase attribute in args.NewItems!)
        {
          if (attribute.OwnerType != null)
          {
            attribute.OwnerType.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
          else if (attribute.OwnerGroup != null)
          {
            attribute.OwnerGroup.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
          else if (attribute.OwnerNamespace != null)
          {
            attribute.OwnerNamespace.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
        }
      }
    };

    foreach (var ns in Namespaces
               .Include(ns => ns.Elements))
    {
      Debug.WriteLine($"Loading namespace: {ns.Url}");
      ns.ElementsDictionary = ns.Elements.ToDictionary(element => element.FullName, element => element);
    }
    Particles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Element element in args.NewItems!.OfType<Element>())
        {
          if (element.OwnerNamespace != null)
            element.OwnerNamespace.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }
    };

    foreach (var ns in Namespaces
           .Include(ns => ns.ElementGroups).ThenInclude(eg => eg.Particle))
    {
      ns.ElementGroupsDictionary = ns.ElementGroups.ToDictionary(group => group.FullName, group => group);
    }
    ElementGroups.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (ElementGroup group in args.NewItems!)
        {
          group.OwnerNamespace.ElementGroupsDictionary.TryAdd(group.FullName, group);
        }
      }
    };

    foreach (var ns in Namespaces
               .Include(ns => ns.Elements))
    {
      ns.ElementsDictionary = ns.Elements.ToDictionary(e => e.FullName, e => e);
    }
    Particles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Element element in args.NewItems!.OfType<Element>())
        {
          element.OwnerNamespace?.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }
    };

    foreach (var complexType in Types.OfType<ComplexType>().Include(type => type.Particle))
    {
    };

    foreach (var particle in Particles.OfType<Element>())
    {
      if (particle.RefElementId != null && particle.RefElement == null)
      {
        particle.RefElement = Particles.OfType<Element>().First(e => e.Id == particle.RefElementId);
      }
      if (particle.RefTypeId != null && particle.RefType == null)
      {
        particle.RefType = Types.OfType<ComplexType>().FirstOrDefault(type => type.Id == particle.RefTypeId);
      }
    }

    foreach (var particle in Particles)
    {
      if (particle.OwnerTypeId != null)
      {
        particle.OwnerType ??= Types.OfType<ComplexType>().FirstOrDefault(type => type.Id == particle.OwnerTypeId);
        if (particle.OwnerType != null)
        {
          particle.OwnerType.ParticleId = particle.Id;
          particle.OwnerType.Particle = particle;
        }
      }
      if (particle.OwnerGroupId != null)
      {
        particle.OwnerGroup ??= ElementGroups.FirstOrDefault(type => type.Id == particle.OwnerGroupId);
        if (particle.OwnerGroup != null)
        {
          particle.OwnerGroup.ParticleId = particle.Id;
          particle.OwnerGroup.Particle = particle as ParticleGroup;
        }
      }
      if (particle.OwnerParticleId != null)
      {
        particle.OwnerParticle ??= Particles.FirstOrDefault(type => type.Id == particle.OwnerParticleId) as ParticleGroup;
        if (particle.OwnerParticle != null)
        {
          particle.OwnerParticle.ItemsDictionary.TryAdd((int)particle.OrdNum!, particle);
        }
      }
      if (particle.OwnerNamespaceId != null)
      {
        particle.OwnerNamespace ??= Namespaces.FirstOrDefault(type => type.Id == particle.OwnerNamespaceId);
        if (particle.OwnerNamespace != null && particle is Element element)
        {
          particle.OwnerNamespace.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }

    }

    SaveChanges();
  }
}
