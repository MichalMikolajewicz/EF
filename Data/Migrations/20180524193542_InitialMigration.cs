﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "Person");

            //migrationBuilder.EnsureSchema(
            //    name: "Production");

            //migrationBuilder.EnsureSchema(
            //    name: "Sales");

            //migrationBuilder.EnsureSchema(
            //    name: "HumanResources");

            //migrationBuilder.EnsureSchema(
            //    name: "Purchasing");

            //migrationBuilder.CreateTable(
            //    name: "__MigrationHistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(maxLength: 150, nullable: false),
            //        ContextKey = table.Column<string>(maxLength: 300, nullable: false),
            //        Model = table.Column<byte[]>(nullable: false),
            //        ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK___MigrationHistory", x => new { x.MigrationId, x.ContextKey });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AWBuildVersion",
            //    columns: table => new
            //    {
            //        SystemInformationID = table.Column<byte>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DatabaseVersion = table.Column<string>(name: "Database Version", maxLength: 25, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        VersionDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AWBuildVersion", x => x.SystemInformationID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DatabaseLog",
            //    columns: table => new
            //    {
            //        DatabaseLogID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DatabaseUser = table.Column<string>(type: "sysname", maxLength: 4000, nullable: false),
            //        Event = table.Column<string>(type: "sysname", maxLength: 4000, nullable: false),
            //        Object = table.Column<string>(type: "sysname", maxLength: 4000, nullable: true),
            //        PostTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Schema = table.Column<string>(type: "sysname", maxLength: 4000, nullable: true),
            //        TSQL = table.Column<string>(nullable: false),
            //        XmlEvent = table.Column<string>(type: "xml", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DatabaseLog", x => x.DatabaseLogID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ErrorLog",
            //    columns: table => new
            //    {
            //        ErrorLogID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ErrorLine = table.Column<int>(nullable: true),
            //        ErrorMessage = table.Column<string>(maxLength: 4000, nullable: false),
            //        ErrorNumber = table.Column<int>(nullable: false),
            //        ErrorProcedure = table.Column<string>(maxLength: 126, nullable: true),
            //        ErrorSeverity = table.Column<int>(nullable: true),
            //        ErrorState = table.Column<int>(nullable: true),
            //        ErrorTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UserName = table.Column<string>(type: "sysname", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ErrorLog", x => x.ErrorLogID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Logs",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        exception = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
            //        logDate = table.Column<DateTime>(nullable: false),
            //        logLevel = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        logMessage = table.Column<string>(unicode: false, maxLength: 4000, nullable: false),
            //        logSource = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
            //        logThread = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Logs", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Department",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        DepartmentID = table.Column<short>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        GroupName = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Department", x => x.DepartmentID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Shift",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        ShiftID = table.Column<byte>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EndTime = table.Column<TimeSpan>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        StartTime = table.Column<TimeSpan>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Shift", x => x.ShiftID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AddressType",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        AddressTypeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AddressType", x => x.AddressTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BusinessEntity",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BusinessEntity", x => x.BusinessEntityID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ContactType",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        ContactTypeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ContactType", x => x.ContactTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CountryRegion",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        CountryRegionCode = table.Column<string>(maxLength: 3, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CountryRegion", x => x.CountryRegionCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PhoneNumberType",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        PhoneNumberTypeID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PhoneNumberType", x => x.PhoneNumberTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Culture",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        CultureID = table.Column<string>(type: "nchar(6)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Culture", x => x.CultureID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Illustration",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        IllustrationID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Diagram = table.Column<string>(type: "xml", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Illustration", x => x.IllustrationID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Location",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        LocationID = table.Column<short>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Availability = table.Column<decimal>(type: "decimal(8, 2)", nullable: false, defaultValueSql: "((0.00))"),
            //        CostRate = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValueSql: "((0.00))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Location", x => x.LocationID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductCategory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductCategoryID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductDescription",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductDescriptionID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Description = table.Column<string>(maxLength: 400, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductDescription", x => x.ProductDescriptionID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductModel",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductModelID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CatalogDescription = table.Column<string>(type: "xml", nullable: true),
            //        Instructions = table.Column<string>(type: "xml", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductModel", x => x.ProductModelID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductPhoto",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductPhotoID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        LargePhoto = table.Column<byte[]>(nullable: true),
            //        LargePhotoFileName = table.Column<string>(maxLength: 50, nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ThumbNailPhoto = table.Column<byte[]>(nullable: true),
            //        ThumbnailPhotoFileName = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductPhoto", x => x.ProductPhotoID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScrapReason",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ScrapReasonID = table.Column<short>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScrapReason", x => x.ScrapReasonID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TransactionHistoryArchive",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        TransactionID = table.Column<int>(nullable: false),
            //        ActualCost = table.Column<decimal>(type: "money", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ProductID = table.Column<int>(nullable: false),
            //        Quantity = table.Column<int>(nullable: false),
            //        ReferenceOrderID = table.Column<int>(nullable: false),
            //        ReferenceOrderLineID = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //        TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        TransactionType = table.Column<string>(type: "nchar(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TransactionHistoryArchive", x => x.TransactionID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UnitMeasure",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        UnitMeasureCode = table.Column<string>(type: "nchar(3)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitMeasure", x => x.UnitMeasureCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ShipMethod",
            //    schema: "Purchasing",
            //    columns: table => new
            //    {
            //        ShipMethodID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        ShipBase = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        ShipRate = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShipMethod", x => x.ShipMethodID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CreditCard",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        CreditCardID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CardNumber = table.Column<string>(maxLength: 25, nullable: false),
            //        CardType = table.Column<string>(maxLength: 50, nullable: false),
            //        ExpMonth = table.Column<byte>(nullable: false),
            //        ExpYear = table.Column<short>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CreditCard", x => x.CreditCardID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Currency",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        CurrencyCode = table.Column<string>(type: "nchar(3)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Currency", x => x.CurrencyCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesReason",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SalesReasonID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        ReasonType = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesReason", x => x.SalesReasonID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SpecialOffer",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SpecialOfferID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Category = table.Column<string>(maxLength: 50, nullable: false),
            //        Description = table.Column<string>(maxLength: 255, nullable: false),
            //        DiscountPct = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValueSql: "((0.00))"),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        MaxQty = table.Column<int>(nullable: true),
            //        MinQty = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Type = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SpecialOffer", x => x.SpecialOfferID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        AdditionalContactInfo = table.Column<string>(type: "xml", nullable: true),
            //        Demographics = table.Column<string>(type: "xml", nullable: true),
            //        EmailPromotion = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //        FirstName = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        LastName = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        MiddleName = table.Column<string>(type: "Name", maxLength: 4000, nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        NameStyle = table.Column<bool>(type: "NameStyle", nullable: false),
            //        PersonType = table.Column<string>(type: "nchar(2)", nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        Suffix = table.Column<string>(maxLength: 10, nullable: true),
            //        Title = table.Column<string>(maxLength: 8, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Person", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_Person_BusinessEntity_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "BusinessEntity",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vendor",
            //    schema: "Purchasing",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        AccountNumber = table.Column<string>(type: "AccountNumber", maxLength: 4000, nullable: false),
            //        ActiveFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        CreditRating = table.Column<byte>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        PreferredVendorStatus = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        PurchasingWebServiceURL = table.Column<string>(maxLength: 1024, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vendor", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_Vendor_BusinessEntity_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "BusinessEntity",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesTerritory",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        TerritoryID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CostLastYear = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        CostYTD = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        CountryRegionCode = table.Column<string>(maxLength: 3, nullable: false),
            //        Group = table.Column<string>(maxLength: 50, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalesLastYear = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        SalesYTD = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesTerritory", x => x.TerritoryID);
            //        table.ForeignKey(
            //            name: "FK_SalesTerritory_CountryRegion_CountryRegionCode",
            //            column: x => x.CountryRegionCode,
            //            principalSchema: "Person",
            //            principalTable: "CountryRegion",
            //            principalColumn: "CountryRegionCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductSubcategory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductSubcategoryID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        ProductCategoryID = table.Column<int>(nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductSubcategory", x => x.ProductSubcategoryID);
            //        table.ForeignKey(
            //            name: "FK_ProductSubcategory_ProductCategory_ProductCategoryID",
            //            column: x => x.ProductCategoryID,
            //            principalSchema: "Production",
            //            principalTable: "ProductCategory",
            //            principalColumn: "ProductCategoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductModelIllustration",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductModelID = table.Column<int>(nullable: false),
            //        IllustrationID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductModelIllustration", x => new { x.ProductModelID, x.IllustrationID });
            //        table.ForeignKey(
            //            name: "FK_ProductModelIllustration_Illustration_IllustrationID",
            //            column: x => x.IllustrationID,
            //            principalSchema: "Production",
            //            principalTable: "Illustration",
            //            principalColumn: "IllustrationID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductModelIllustration_ProductModel_ProductModelID",
            //            column: x => x.ProductModelID,
            //            principalSchema: "Production",
            //            principalTable: "ProductModel",
            //            principalColumn: "ProductModelID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductModelProductDescriptionCulture",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductModelID = table.Column<int>(nullable: false),
            //        ProductDescriptionID = table.Column<int>(nullable: false),
            //        CultureID = table.Column<string>(type: "nchar(6)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductModelProductDescriptionCulture", x => new { x.ProductModelID, x.ProductDescriptionID, x.CultureID });
            //        table.ForeignKey(
            //            name: "FK_ProductModelProductDescriptionCulture_Culture_CultureID",
            //            column: x => x.CultureID,
            //            principalSchema: "Production",
            //            principalTable: "Culture",
            //            principalColumn: "CultureID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID",
            //            column: x => x.ProductDescriptionID,
            //            principalSchema: "Production",
            //            principalTable: "ProductDescription",
            //            principalColumn: "ProductDescriptionID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID",
            //            column: x => x.ProductModelID,
            //            principalSchema: "Production",
            //            principalTable: "ProductModel",
            //            principalColumn: "ProductModelID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CountryRegionCurrency",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        CountryRegionCode = table.Column<string>(maxLength: 3, nullable: false),
            //        CurrencyCode = table.Column<string>(type: "nchar(3)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CountryRegionCurrency", x => new { x.CountryRegionCode, x.CurrencyCode });
            //        table.ForeignKey(
            //            name: "FK_CountryRegionCurrency_CountryRegion_CountryRegionCode",
            //            column: x => x.CountryRegionCode,
            //            principalSchema: "Person",
            //            principalTable: "CountryRegion",
            //            principalColumn: "CountryRegionCode",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CountryRegionCurrency_Currency_CurrencyCode",
            //            column: x => x.CurrencyCode,
            //            principalSchema: "Sales",
            //            principalTable: "Currency",
            //            principalColumn: "CurrencyCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CurrencyRate",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        CurrencyRateID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        AverageRate = table.Column<decimal>(type: "money", nullable: false),
            //        CurrencyRateDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndOfDayRate = table.Column<decimal>(type: "money", nullable: false),
            //        FromCurrencyCode = table.Column<string>(type: "nchar(3)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ToCurrencyCode = table.Column<string>(type: "nchar(3)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CurrencyRate", x => x.CurrencyRateID);
            //        table.ForeignKey(
            //            name: "FK_CurrencyRate_Currency_FromCurrencyCode",
            //            column: x => x.FromCurrencyCode,
            //            principalSchema: "Sales",
            //            principalTable: "Currency",
            //            principalColumn: "CurrencyCode",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CurrencyRate_Currency_ToCurrencyCode",
            //            column: x => x.ToCurrencyCode,
            //            principalSchema: "Sales",
            //            principalTable: "Currency",
            //            principalColumn: "CurrencyCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Employee",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        BirthDate = table.Column<DateTime>(type: "date", nullable: false),
            //        CurrentFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        Gender = table.Column<string>(type: "nchar(1)", nullable: false),
            //        HireDate = table.Column<DateTime>(type: "date", nullable: false),
            //        JobTitle = table.Column<string>(maxLength: 50, nullable: false),
            //        LoginID = table.Column<string>(maxLength: 256, nullable: false),
            //        MaritalStatus = table.Column<string>(type: "nchar(1)", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        NationalIDNumber = table.Column<string>(maxLength: 15, nullable: false),
            //        OrganizationLevel = table.Column<short>(nullable: true, computedColumnSql: "([OrganizationNode].[GetLevel]())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalariedFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        SickLeaveHours = table.Column<short>(nullable: false, defaultValueSql: "((0))"),
            //        VacationHours = table.Column<short>(nullable: false, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employee", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_Employee_Person_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BusinessEntityContact",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        PersonID = table.Column<int>(nullable: false),
            //        ContactTypeID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BusinessEntityContact", x => new { x.BusinessEntityID, x.PersonID, x.ContactTypeID });
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityContact_BusinessEntity_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "BusinessEntity",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityContact_ContactType_ContactTypeID",
            //            column: x => x.ContactTypeID,
            //            principalSchema: "Person",
            //            principalTable: "ContactType",
            //            principalColumn: "ContactTypeID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityContact_Person_PersonID",
            //            column: x => x.PersonID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmailAddress",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        EmailAddressID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmailAddress", x => new { x.BusinessEntityID, x.EmailAddressID });
            //        table.ForeignKey(
            //            name: "FK_EmailAddress_Person_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Password",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PasswordHash = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        PasswordSalt = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Password", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_Password_Person_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PersonPhone",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        PhoneNumber = table.Column<string>(type: "Phone", maxLength: 4000, nullable: false),
            //        PhoneNumberTypeID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PersonPhone", x => new { x.BusinessEntityID, x.PhoneNumber, x.PhoneNumberTypeID });
            //        table.ForeignKey(
            //            name: "FK_PersonPhone_Person_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID",
            //            column: x => x.PhoneNumberTypeID,
            //            principalSchema: "Person",
            //            principalTable: "PhoneNumberType",
            //            principalColumn: "PhoneNumberTypeID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PersonCreditCard",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        CreditCardID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PersonCreditCard", x => new { x.BusinessEntityID, x.CreditCardID });
            //        table.ForeignKey(
            //            name: "FK_PersonCreditCard_Person_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PersonCreditCard_CreditCard_CreditCardID",
            //            column: x => x.CreditCardID,
            //            principalSchema: "Sales",
            //            principalTable: "CreditCard",
            //            principalColumn: "CreditCardID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StateProvince",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        StateProvinceID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CountryRegionCode = table.Column<string>(maxLength: 3, nullable: false),
            //        IsOnlyStateProvinceFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        StateProvinceCode = table.Column<string>(type: "nchar(3)", nullable: false),
            //        TerritoryID = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StateProvince", x => x.StateProvinceID);
            //        table.ForeignKey(
            //            name: "FK_StateProvince_CountryRegion_CountryRegionCode",
            //            column: x => x.CountryRegionCode,
            //            principalSchema: "Person",
            //            principalTable: "CountryRegion",
            //            principalColumn: "CountryRegionCode",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_StateProvince_SalesTerritory_TerritoryID",
            //            column: x => x.TerritoryID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesTerritory",
            //            principalColumn: "TerritoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Product",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Class = table.Column<string>(type: "nchar(2)", nullable: true),
            //        Color = table.Column<string>(maxLength: 15, nullable: true),
            //        DaysToManufacture = table.Column<int>(nullable: false),
            //        DiscontinuedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        FinishedGoodsFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        ListPrice = table.Column<decimal>(type: "money", nullable: false),
            //        MakeFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        ProductLine = table.Column<string>(type: "nchar(2)", nullable: true),
            //        ProductModelID = table.Column<int>(nullable: true),
            //        ProductNumber = table.Column<string>(maxLength: 25, nullable: false),
            //        ProductSubcategoryID = table.Column<int>(nullable: true),
            //        ReorderPoint = table.Column<short>(nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SafetyStockLevel = table.Column<short>(nullable: false),
            //        SellEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        SellStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Size = table.Column<string>(maxLength: 5, nullable: true),
            //        SizeUnitMeasureCode = table.Column<string>(type: "nchar(3)", nullable: true),
            //        StandardCost = table.Column<decimal>(type: "money", nullable: false),
            //        Style = table.Column<string>(type: "nchar(2)", nullable: true),
            //        Weight = table.Column<decimal>(type: "decimal(8, 2)", nullable: true),
            //        WeightUnitMeasureCode = table.Column<string>(type: "nchar(3)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.ProductID);
            //        table.ForeignKey(
            //            name: "FK_Product_ProductModel_ProductModelID",
            //            column: x => x.ProductModelID,
            //            principalSchema: "Production",
            //            principalTable: "ProductModel",
            //            principalColumn: "ProductModelID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Product_ProductSubcategory_ProductSubcategoryID",
            //            column: x => x.ProductSubcategoryID,
            //            principalSchema: "Production",
            //            principalTable: "ProductSubcategory",
            //            principalColumn: "ProductSubcategoryID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Product_UnitMeasure_SizeUnitMeasureCode",
            //            column: x => x.SizeUnitMeasureCode,
            //            principalSchema: "Production",
            //            principalTable: "UnitMeasure",
            //            principalColumn: "UnitMeasureCode",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Product_UnitMeasure_WeightUnitMeasureCode",
            //            column: x => x.WeightUnitMeasureCode,
            //            principalSchema: "Production",
            //            principalTable: "UnitMeasure",
            //            principalColumn: "UnitMeasureCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmployeeDepartmentHistory",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        StartDate = table.Column<DateTime>(type: "date", nullable: false),
            //        DepartmentID = table.Column<short>(nullable: false),
            //        ShiftID = table.Column<byte>(nullable: false),
            //        EndDate = table.Column<DateTime>(type: "date", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmployeeDepartmentHistory", x => new { x.BusinessEntityID, x.StartDate, x.DepartmentID, x.ShiftID });
            //        table.ForeignKey(
            //            name: "FK_EmployeeDepartmentHistory_Employee_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Employee",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_EmployeeDepartmentHistory_Department_DepartmentID",
            //            column: x => x.DepartmentID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Department",
            //            principalColumn: "DepartmentID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_EmployeeDepartmentHistory_Shift_ShiftID",
            //            column: x => x.ShiftID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Shift",
            //            principalColumn: "ShiftID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmployeePayHistory",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        RateChangeDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PayFrequency = table.Column<byte>(nullable: false),
            //        Rate = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmployeePayHistory", x => new { x.BusinessEntityID, x.RateChangeDate });
            //        table.ForeignKey(
            //            name: "FK_EmployeePayHistory_Employee_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Employee",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JobCandidate",
            //    schema: "HumanResources",
            //    columns: table => new
            //    {
            //        JobCandidateID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        BusinessEntityID = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Resume = table.Column<string>(type: "xml", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_JobCandidate", x => x.JobCandidateID);
            //        table.ForeignKey(
            //            name: "FK_JobCandidate_Employee_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Employee",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PurchaseOrderHeader",
            //    schema: "Purchasing",
            //    columns: table => new
            //    {
            //        PurchaseOrderID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EmployeeID = table.Column<int>(nullable: false),
            //        Freight = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OrderDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        RevisionNumber = table.Column<byte>(nullable: false, defaultValueSql: "((0))"),
            //        ShipDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShipMethodID = table.Column<int>(nullable: false),
            //        Status = table.Column<byte>(nullable: false, defaultValueSql: "((1))"),
            //        SubTotal = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        TaxAmt = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        TotalDue = table.Column<decimal>(type: "money", nullable: false, computedColumnSql: "(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))"),
            //        VendorID = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PurchaseOrderHeader", x => x.PurchaseOrderID);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderHeader_Employee_EmployeeID",
            //            column: x => x.EmployeeID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Employee",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderHeader_ShipMethod_ShipMethodID",
            //            column: x => x.ShipMethodID,
            //            principalSchema: "Purchasing",
            //            principalTable: "ShipMethod",
            //            principalColumn: "ShipMethodID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderHeader_Vendor_VendorID",
            //            column: x => x.VendorID,
            //            principalSchema: "Purchasing",
            //            principalTable: "Vendor",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesPerson",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        Bonus = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        CommissionPct = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValueSql: "((0.00))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalesLastYear = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        SalesQuota = table.Column<decimal>(type: "money", nullable: true),
            //        SalesYTD = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        TerritoryID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesPerson", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_SalesPerson_Employee_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "HumanResources",
            //            principalTable: "Employee",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesPerson_SalesTerritory_TerritoryID",
            //            column: x => x.TerritoryID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesTerritory",
            //            principalColumn: "TerritoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Address",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        AddressID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        AddressLine1 = table.Column<string>(maxLength: 60, nullable: false),
            //        AddressLine2 = table.Column<string>(maxLength: 60, nullable: true),
            //        City = table.Column<string>(maxLength: 30, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PostalCode = table.Column<string>(maxLength: 15, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        StateProvinceID = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Address", x => x.AddressID);
            //        table.ForeignKey(
            //            name: "FK_Address_StateProvince_StateProvinceID",
            //            column: x => x.StateProvinceID,
            //            principalSchema: "Person",
            //            principalTable: "StateProvince",
            //            principalColumn: "StateProvinceID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesTaxRate",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SalesTaxRateID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        StateProvinceID = table.Column<int>(nullable: false),
            //        TaxRate = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValueSql: "((0.00))"),
            //        TaxType = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesTaxRate", x => x.SalesTaxRateID);
            //        table.ForeignKey(
            //            name: "FK_SalesTaxRate_StateProvince_StateProvinceID",
            //            column: x => x.StateProvinceID,
            //            principalSchema: "Person",
            //            principalTable: "StateProvince",
            //            principalColumn: "StateProvinceID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BillOfMaterials",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        BillOfMaterialsID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        BOMLevel = table.Column<short>(nullable: false),
            //        ComponentID = table.Column<int>(nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PerAssemblyQty = table.Column<decimal>(type: "decimal(8, 2)", nullable: false, defaultValueSql: "((1.00))"),
            //        ProductAssemblyID = table.Column<int>(nullable: true),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        UnitMeasureCode = table.Column<string>(type: "nchar(3)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BillOfMaterials", x => x.BillOfMaterialsID);
            //        table.ForeignKey(
            //            name: "FK_BillOfMaterials_Product_ComponentID",
            //            column: x => x.ComponentID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BillOfMaterials_Product_ProductAssemblyID",
            //            column: x => x.ProductAssemblyID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BillOfMaterials_UnitMeasure_UnitMeasureCode",
            //            column: x => x.UnitMeasureCode,
            //            principalSchema: "Production",
            //            principalTable: "UnitMeasure",
            //            principalColumn: "UnitMeasureCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductCostHistory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        StandardCost = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductCostHistory", x => new { x.ProductID, x.StartDate });
            //        table.ForeignKey(
            //            name: "FK_ProductCostHistory_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductInventory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false),
            //        LocationID = table.Column<short>(nullable: false),
            //        Bin = table.Column<byte>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Quantity = table.Column<short>(nullable: false, defaultValueSql: "((0))"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        Shelf = table.Column<string>(maxLength: 10, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductInventory", x => new { x.ProductID, x.LocationID });
            //        table.ForeignKey(
            //            name: "FK_ProductInventory_Location_LocationID",
            //            column: x => x.LocationID,
            //            principalSchema: "Production",
            //            principalTable: "Location",
            //            principalColumn: "LocationID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductInventory_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductListPriceHistory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ListPrice = table.Column<decimal>(type: "money", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductListPriceHistory", x => new { x.ProductID, x.StartDate });
            //        table.ForeignKey(
            //            name: "FK_ProductListPriceHistory_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductProductPhoto",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false),
            //        ProductPhotoID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Primary = table.Column<bool>(type: "Flag", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductProductPhoto", x => new { x.ProductID, x.ProductPhotoID })
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK_ProductProductPhoto_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductProductPhoto_ProductPhoto_ProductPhotoID",
            //            column: x => x.ProductPhotoID,
            //            principalSchema: "Production",
            //            principalTable: "ProductPhoto",
            //            principalColumn: "ProductPhotoID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductReview",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        ProductReviewID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Comments = table.Column<string>(maxLength: 3850, nullable: true),
            //        EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ProductID = table.Column<int>(nullable: false),
            //        Rating = table.Column<int>(nullable: false),
            //        ReviewDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ReviewerName = table.Column<string>(type: "Name", maxLength: 4000, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductReview", x => x.ProductReviewID);
            //        table.ForeignKey(
            //            name: "FK_ProductReview_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TransactionHistory",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        TransactionID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        ActualCost = table.Column<decimal>(type: "money", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ProductID = table.Column<int>(nullable: false),
            //        Quantity = table.Column<int>(nullable: false),
            //        ReferenceOrderID = table.Column<int>(nullable: false),
            //        ReferenceOrderLineID = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //        TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        TransactionType = table.Column<string>(type: "nchar(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TransactionHistory", x => x.TransactionID);
            //        table.ForeignKey(
            //            name: "FK_TransactionHistory_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WorkOrder",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        WorkOrderID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OrderQty = table.Column<int>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        ScrapReasonID = table.Column<short>(nullable: true),
            //        ScrappedQty = table.Column<short>(nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        StockedQty = table.Column<int>(nullable: false, computedColumnSql: "(isnull([OrderQty]-[ScrappedQty],(0)))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WorkOrder", x => x.WorkOrderID);
            //        table.ForeignKey(
            //            name: "FK_WorkOrder_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_WorkOrder_ScrapReason_ScrapReasonID",
            //            column: x => x.ScrapReasonID,
            //            principalSchema: "Production",
            //            principalTable: "ScrapReason",
            //            principalColumn: "ScrapReasonID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductVendor",
            //    schema: "Purchasing",
            //    columns: table => new
            //    {
            //        ProductID = table.Column<int>(nullable: false),
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        AverageLeadTime = table.Column<int>(nullable: false),
            //        LastReceiptCost = table.Column<decimal>(type: "money", nullable: true),
            //        LastReceiptDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        MaxOrderQty = table.Column<int>(nullable: false),
            //        MinOrderQty = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OnOrderQty = table.Column<int>(nullable: true),
            //        StandardPrice = table.Column<decimal>(type: "money", nullable: false),
            //        UnitMeasureCode = table.Column<string>(type: "nchar(3)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductVendor", x => new { x.ProductID, x.BusinessEntityID });
            //        table.ForeignKey(
            //            name: "FK_ProductVendor_Vendor_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Purchasing",
            //            principalTable: "Vendor",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductVendor_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ProductVendor_UnitMeasure_UnitMeasureCode",
            //            column: x => x.UnitMeasureCode,
            //            principalSchema: "Production",
            //            principalTable: "UnitMeasure",
            //            principalColumn: "UnitMeasureCode",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ShoppingCartItem",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        ShoppingCartItemID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ProductID = table.Column<int>(nullable: false),
            //        Quantity = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
            //        ShoppingCartID = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShoppingCartItem", x => x.ShoppingCartItemID);
            //        table.ForeignKey(
            //            name: "FK_ShoppingCartItem_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SpecialOfferProduct",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SpecialOfferID = table.Column<int>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SpecialOfferProduct", x => new { x.SpecialOfferID, x.ProductID });
            //        table.ForeignKey(
            //            name: "FK_SpecialOfferProduct_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID",
            //            column: x => x.SpecialOfferID,
            //            principalSchema: "Sales",
            //            principalTable: "SpecialOffer",
            //            principalColumn: "SpecialOfferID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PurchaseOrderDetail",
            //    schema: "Purchasing",
            //    columns: table => new
            //    {
            //        PurchaseOrderID = table.Column<int>(nullable: false),
            //        PurchaseOrderDetailID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LineTotal = table.Column<decimal>(type: "money", nullable: false, computedColumnSql: "(isnull([OrderQty]*[UnitPrice],(0.00)))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OrderQty = table.Column<short>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        ReceivedQty = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
            //        RejectedQty = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
            //        StockedQty = table.Column<decimal>(type: "decimal(9, 2)", nullable: false, computedColumnSql: "(isnull([ReceivedQty]-[RejectedQty],(0.00)))"),
            //        UnitPrice = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PurchaseOrderDetail", x => new { x.PurchaseOrderID, x.PurchaseOrderDetailID });
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderDetail_Product_ProductID",
            //            column: x => x.ProductID,
            //            principalSchema: "Production",
            //            principalTable: "Product",
            //            principalColumn: "ProductID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID",
            //            column: x => x.PurchaseOrderID,
            //            principalSchema: "Purchasing",
            //            principalTable: "PurchaseOrderHeader",
            //            principalColumn: "PurchaseOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesPersonQuotaHistory",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        QuotaDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalesQuota = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesPersonQuotaHistory", x => new { x.BusinessEntityID, x.QuotaDate });
            //        table.ForeignKey(
            //            name: "FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesPerson",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesTerritoryHistory",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        TerritoryID = table.Column<int>(nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesTerritoryHistory", x => new { x.BusinessEntityID, x.StartDate, x.TerritoryID });
            //        table.ForeignKey(
            //            name: "FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesPerson",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesTerritoryHistory_SalesTerritory_TerritoryID",
            //            column: x => x.TerritoryID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesTerritory",
            //            principalColumn: "TerritoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Store",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        Demographics = table.Column<string>(type: "xml", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        Name = table.Column<string>(type: "Name", maxLength: 4000, nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalesPersonID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Store", x => x.BusinessEntityID);
            //        table.ForeignKey(
            //            name: "FK_Store_BusinessEntity_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "BusinessEntity",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Store_SalesPerson_SalesPersonID",
            //            column: x => x.SalesPersonID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesPerson",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BusinessEntityAddress",
            //    schema: "Person",
            //    columns: table => new
            //    {
            //        BusinessEntityID = table.Column<int>(nullable: false),
            //        AddressID = table.Column<int>(nullable: false),
            //        AddressTypeID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BusinessEntityAddress", x => new { x.BusinessEntityID, x.AddressID, x.AddressTypeID });
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityAddress_Address_AddressID",
            //            column: x => x.AddressID,
            //            principalSchema: "Person",
            //            principalTable: "Address",
            //            principalColumn: "AddressID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityAddress_AddressType_AddressTypeID",
            //            column: x => x.AddressTypeID,
            //            principalSchema: "Person",
            //            principalTable: "AddressType",
            //            principalColumn: "AddressTypeID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID",
            //            column: x => x.BusinessEntityID,
            //            principalSchema: "Person",
            //            principalTable: "BusinessEntity",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WorkOrderRouting",
            //    schema: "Production",
            //    columns: table => new
            //    {
            //        WorkOrderID = table.Column<int>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        OperationSequence = table.Column<short>(nullable: false),
            //        ActualCost = table.Column<decimal>(type: "money", nullable: true),
            //        ActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ActualResourceHrs = table.Column<decimal>(type: "decimal(9, 4)", nullable: true),
            //        ActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        LocationID = table.Column<short>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PlannedCost = table.Column<decimal>(type: "money", nullable: false),
            //        ScheduledEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ScheduledStartDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WorkOrderRouting", x => new { x.WorkOrderID, x.ProductID, x.OperationSequence });
            //        table.ForeignKey(
            //            name: "FK_WorkOrderRouting_Location_LocationID",
            //            column: x => x.LocationID,
            //            principalSchema: "Production",
            //            principalTable: "Location",
            //            principalColumn: "LocationID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_WorkOrderRouting_WorkOrder_WorkOrderID",
            //            column: x => x.WorkOrderID,
            //            principalSchema: "Production",
            //            principalTable: "WorkOrder",
            //            principalColumn: "WorkOrderID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customer",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        CustomerID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        AccountNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: false, computedColumnSql: "(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PersonID = table.Column<int>(nullable: true),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        StoreID = table.Column<int>(nullable: true),
            //        TerritoryID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customer", x => x.CustomerID);
            //        table.ForeignKey(
            //            name: "FK_Customer_Person_PersonID",
            //            column: x => x.PersonID,
            //            principalSchema: "Person",
            //            principalTable: "Person",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Customer_Store_StoreID",
            //            column: x => x.StoreID,
            //            principalSchema: "Sales",
            //            principalTable: "Store",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Customer_SalesTerritory_TerritoryID",
            //            column: x => x.TerritoryID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesTerritory",
            //            principalColumn: "TerritoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesOrderHeader",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SalesOrderID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        AccountNumber = table.Column<string>(type: "AccountNumber", maxLength: 4000, nullable: true),
            //        BillToAddressID = table.Column<int>(nullable: false),
            //        Comment = table.Column<string>(maxLength: 128, nullable: true),
            //        CreditCardApprovalCode = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
            //        CreditCardID = table.Column<int>(nullable: true),
            //        CurrencyRateID = table.Column<int>(nullable: true),
            //        CustomerID = table.Column<int>(nullable: false),
            //        DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Freight = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OnlineOrderFlag = table.Column<bool>(type: "Flag", nullable: true, defaultValueSql: "((1))"),
            //        OrderDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        PurchaseOrderNumber = table.Column<string>(type: "OrderNumber", maxLength: 4000, nullable: true),
            //        RevisionNumber = table.Column<byte>(nullable: false, defaultValueSql: "((0))"),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SalesOrderNumber = table.Column<string>(maxLength: 25, nullable: false, computedColumnSql: "(isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***'))"),
            //        SalesPersonID = table.Column<int>(nullable: true),
            //        ShipDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ShipMethodID = table.Column<int>(nullable: false),
            //        ShipToAddressID = table.Column<int>(nullable: false),
            //        Status = table.Column<byte>(nullable: false, defaultValueSql: "((1))"),
            //        SubTotal = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        TaxAmt = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
            //        TerritoryID = table.Column<int>(nullable: true),
            //        TotalDue = table.Column<decimal>(type: "money", nullable: false, computedColumnSql: "(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesOrderHeader", x => x.SalesOrderID);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_Address_BillToAddressID",
            //            column: x => x.BillToAddressID,
            //            principalSchema: "Person",
            //            principalTable: "Address",
            //            principalColumn: "AddressID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_CreditCard_CreditCardID",
            //            column: x => x.CreditCardID,
            //            principalSchema: "Sales",
            //            principalTable: "CreditCard",
            //            principalColumn: "CreditCardID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_CurrencyRate_CurrencyRateID",
            //            column: x => x.CurrencyRateID,
            //            principalSchema: "Sales",
            //            principalTable: "CurrencyRate",
            //            principalColumn: "CurrencyRateID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_Customer_CustomerID",
            //            column: x => x.CustomerID,
            //            principalSchema: "Sales",
            //            principalTable: "Customer",
            //            principalColumn: "CustomerID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_SalesPerson_SalesPersonID",
            //            column: x => x.SalesPersonID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesPerson",
            //            principalColumn: "BusinessEntityID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_ShipMethod_ShipMethodID",
            //            column: x => x.ShipMethodID,
            //            principalSchema: "Purchasing",
            //            principalTable: "ShipMethod",
            //            principalColumn: "ShipMethodID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_Address_ShipToAddressID",
            //            column: x => x.ShipToAddressID,
            //            principalSchema: "Person",
            //            principalTable: "Address",
            //            principalColumn: "AddressID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeader_SalesTerritory_TerritoryID",
            //            column: x => x.TerritoryID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesTerritory",
            //            principalColumn: "TerritoryID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesOrderDetail",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SalesOrderID = table.Column<int>(nullable: false),
            //        SalesOrderDetailID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CarrierTrackingNumber = table.Column<string>(maxLength: 25, nullable: true),
            //        LineTotal = table.Column<decimal>(type: "numeric(, 6)", nullable: false, computedColumnSql: "(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        OrderQty = table.Column<short>(nullable: false),
            //        ProductID = table.Column<int>(nullable: false),
            //        rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        SpecialOfferID = table.Column<int>(nullable: false),
            //        UnitPrice = table.Column<decimal>(type: "money", nullable: false),
            //        UnitPriceDiscount = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesOrderDetail", x => new { x.SalesOrderID, x.SalesOrderDetailID });
            //        table.ForeignKey(
            //            name: "FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID",
            //            column: x => x.SalesOrderID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesOrderHeader",
            //            principalColumn: "SalesOrderID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID",
            //            columns: x => new { x.SpecialOfferID, x.ProductID },
            //            principalSchema: "Sales",
            //            principalTable: "SpecialOfferProduct",
            //            principalColumns: new[] { "SpecialOfferID", "ProductID" },
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesOrderHeaderSalesReason",
            //    schema: "Sales",
            //    columns: table => new
            //    {
            //        SalesOrderID = table.Column<int>(nullable: false),
            //        SalesReasonID = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesOrderHeaderSalesReason", x => new { x.SalesOrderID, x.SalesReasonID });
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID",
            //            column: x => x.SalesOrderID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesOrderHeader",
            //            principalColumn: "SalesOrderID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID",
            //            column: x => x.SalesReasonID,
            //            principalSchema: "Sales",
            //            principalTable: "SalesReason",
            //            principalColumn: "SalesReasonID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "AK_Department_Name",
            //    schema: "HumanResources",
            //    table: "Department",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Employee_LoginID",
            //    schema: "HumanResources",
            //    table: "Employee",
            //    column: "LoginID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Employee_NationalIDNumber",
            //    schema: "HumanResources",
            //    table: "Employee",
            //    column: "NationalIDNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Employee_rowguid",
            //    schema: "HumanResources",
            //    table: "Employee",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmployeeDepartmentHistory_DepartmentID",
            //    schema: "HumanResources",
            //    table: "EmployeeDepartmentHistory",
            //    column: "DepartmentID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmployeeDepartmentHistory_ShiftID",
            //    schema: "HumanResources",
            //    table: "EmployeeDepartmentHistory",
            //    column: "ShiftID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_JobCandidate_BusinessEntityID",
            //    schema: "HumanResources",
            //    table: "JobCandidate",
            //    column: "BusinessEntityID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Shift_Name",
            //    schema: "HumanResources",
            //    table: "Shift",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Shift_StartTime_EndTime",
            //    schema: "HumanResources",
            //    table: "Shift",
            //    columns: new[] { "StartTime", "EndTime" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Address_rowguid",
            //    schema: "Person",
            //    table: "Address",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Address_StateProvinceID",
            //    schema: "Person",
            //    table: "Address",
            //    column: "StateProvinceID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode",
            //    schema: "Person",
            //    table: "Address",
            //    columns: new[] { "AddressLine1", "AddressLine2", "City", "StateProvinceID", "PostalCode" },
            //    unique: true,
            //    filter: "[AddressLine2] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "AK_AddressType_Name",
            //    schema: "Person",
            //    table: "AddressType",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_AddressType_rowguid",
            //    schema: "Person",
            //    table: "AddressType",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_BusinessEntity_rowguid",
            //    schema: "Person",
            //    table: "BusinessEntity",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessEntityAddress_AddressID",
            //    schema: "Person",
            //    table: "BusinessEntityAddress",
            //    column: "AddressID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessEntityAddress_AddressTypeID",
            //    schema: "Person",
            //    table: "BusinessEntityAddress",
            //    column: "AddressTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_BusinessEntityAddress_rowguid",
            //    schema: "Person",
            //    table: "BusinessEntityAddress",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessEntityContact_ContactTypeID",
            //    schema: "Person",
            //    table: "BusinessEntityContact",
            //    column: "ContactTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BusinessEntityContact_PersonID",
            //    schema: "Person",
            //    table: "BusinessEntityContact",
            //    column: "PersonID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_BusinessEntityContact_rowguid",
            //    schema: "Person",
            //    table: "BusinessEntityContact",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ContactType_Name",
            //    schema: "Person",
            //    table: "ContactType",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_CountryRegion_Name",
            //    schema: "Person",
            //    table: "CountryRegion",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmailAddress_EmailAddress",
            //    schema: "Person",
            //    table: "EmailAddress",
            //    column: "EmailAddress");

            //migrationBuilder.CreateIndex(
            //    name: "PXML_Person_AddContact",
            //    schema: "Person",
            //    table: "Person",
            //    column: "AdditionalContactInfo");

            //migrationBuilder.CreateIndex(
            //    name: "XMLVALUE_Person_Demographics",
            //    schema: "Person",
            //    table: "Person",
            //    column: "Demographics");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Person_rowguid",
            //    schema: "Person",
            //    table: "Person",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Person_LastName_FirstName_MiddleName",
            //    schema: "Person",
            //    table: "Person",
            //    columns: new[] { "LastName", "FirstName", "MiddleName" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_PersonPhone_PhoneNumber",
            //    schema: "Person",
            //    table: "PersonPhone",
            //    column: "PhoneNumber");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PersonPhone_PhoneNumberTypeID",
            //    schema: "Person",
            //    table: "PersonPhone",
            //    column: "PhoneNumberTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StateProvince_CountryRegionCode",
            //    schema: "Person",
            //    table: "StateProvince",
            //    column: "CountryRegionCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_StateProvince_Name",
            //    schema: "Person",
            //    table: "StateProvince",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_StateProvince_rowguid",
            //    schema: "Person",
            //    table: "StateProvince",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_StateProvince_TerritoryID",
            //    schema: "Person",
            //    table: "StateProvince",
            //    column: "TerritoryID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_StateProvince_StateProvinceCode_CountryRegionCode",
            //    schema: "Person",
            //    table: "StateProvince",
            //    columns: new[] { "StateProvinceCode", "CountryRegionCode" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_BillOfMaterials_ComponentID",
            //    schema: "Production",
            //    table: "BillOfMaterials",
            //    column: "ComponentID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BillOfMaterials_UnitMeasureCode",
            //    schema: "Production",
            //    table: "BillOfMaterials",
            //    column: "UnitMeasureCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate",
            //    schema: "Production",
            //    table: "BillOfMaterials",
            //    columns: new[] { "ProductAssemblyID", "ComponentID", "StartDate" },
            //    unique: true)
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Culture_Name",
            //    schema: "Production",
            //    table: "Culture",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Location_Name",
            //    schema: "Production",
            //    table: "Location",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Product_Name",
            //    schema: "Production",
            //    table: "Product",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_ProductModelID",
            //    schema: "Production",
            //    table: "Product",
            //    column: "ProductModelID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Product_ProductNumber",
            //    schema: "Production",
            //    table: "Product",
            //    column: "ProductNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_ProductSubcategoryID",
            //    schema: "Production",
            //    table: "Product",
            //    column: "ProductSubcategoryID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Product_rowguid",
            //    schema: "Production",
            //    table: "Product",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_SizeUnitMeasureCode",
            //    schema: "Production",
            //    table: "Product",
            //    column: "SizeUnitMeasureCode");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_WeightUnitMeasureCode",
            //    schema: "Production",
            //    table: "Product",
            //    column: "WeightUnitMeasureCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductCategory_Name",
            //    schema: "Production",
            //    table: "ProductCategory",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductCategory_rowguid",
            //    schema: "Production",
            //    table: "ProductCategory",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductDescription_rowguid",
            //    schema: "Production",
            //    table: "ProductDescription",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductInventory_LocationID",
            //    schema: "Production",
            //    table: "ProductInventory",
            //    column: "LocationID");

            //migrationBuilder.CreateIndex(
            //    name: "PXML_ProductModel_CatalogDescription",
            //    schema: "Production",
            //    table: "ProductModel",
            //    column: "CatalogDescription");

            //migrationBuilder.CreateIndex(
            //    name: "PXML_ProductModel_Instructions",
            //    schema: "Production",
            //    table: "ProductModel",
            //    column: "Instructions");

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductModel_Name",
            //    schema: "Production",
            //    table: "ProductModel",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductModel_rowguid",
            //    schema: "Production",
            //    table: "ProductModel",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductModelIllustration_IllustrationID",
            //    schema: "Production",
            //    table: "ProductModelIllustration",
            //    column: "IllustrationID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductModelProductDescriptionCulture_CultureID",
            //    schema: "Production",
            //    table: "ProductModelProductDescriptionCulture",
            //    column: "CultureID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductModelProductDescriptionCulture_ProductDescriptionID",
            //    schema: "Production",
            //    table: "ProductModelProductDescriptionCulture",
            //    column: "ProductDescriptionID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductProductPhoto_ProductPhotoID",
            //    schema: "Production",
            //    table: "ProductProductPhoto",
            //    column: "ProductPhotoID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductReview_ProductID",
            //    schema: "Production",
            //    table: "ProductReview",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductReview_ProductID_Name",
            //    schema: "Production",
            //    table: "ProductReview",
            //    columns: new[] { "Comments", "ProductID", "ReviewerName" });

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductSubcategory_Name",
            //    schema: "Production",
            //    table: "ProductSubcategory",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductSubcategory_ProductCategoryID",
            //    schema: "Production",
            //    table: "ProductSubcategory",
            //    column: "ProductCategoryID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_ProductSubcategory_rowguid",
            //    schema: "Production",
            //    table: "ProductSubcategory",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ScrapReason_Name",
            //    schema: "Production",
            //    table: "ScrapReason",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_TransactionHistory_ProductID",
            //    schema: "Production",
            //    table: "TransactionHistory",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID",
            //    schema: "Production",
            //    table: "TransactionHistory",
            //    columns: new[] { "ReferenceOrderID", "ReferenceOrderLineID" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_TransactionHistoryArchive_ProductID",
            //    schema: "Production",
            //    table: "TransactionHistoryArchive",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID",
            //    schema: "Production",
            //    table: "TransactionHistoryArchive",
            //    columns: new[] { "ReferenceOrderID", "ReferenceOrderLineID" });

            //migrationBuilder.CreateIndex(
            //    name: "AK_UnitMeasure_Name",
            //    schema: "Production",
            //    table: "UnitMeasure",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_WorkOrder_ProductID",
            //    schema: "Production",
            //    table: "WorkOrder",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WorkOrder_ScrapReasonID",
            //    schema: "Production",
            //    table: "WorkOrder",
            //    column: "ScrapReasonID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WorkOrderRouting_LocationID",
            //    schema: "Production",
            //    table: "WorkOrderRouting",
            //    column: "LocationID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WorkOrderRouting_ProductID",
            //    schema: "Production",
            //    table: "WorkOrderRouting",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductVendor_BusinessEntityID",
            //    schema: "Purchasing",
            //    table: "ProductVendor",
            //    column: "BusinessEntityID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductVendor_UnitMeasureCode",
            //    schema: "Purchasing",
            //    table: "ProductVendor",
            //    column: "UnitMeasureCode");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderDetail_ProductID",
            //    schema: "Purchasing",
            //    table: "PurchaseOrderDetail",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderHeader_EmployeeID",
            //    schema: "Purchasing",
            //    table: "PurchaseOrderHeader",
            //    column: "EmployeeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderHeader_ShipMethodID",
            //    schema: "Purchasing",
            //    table: "PurchaseOrderHeader",
            //    column: "ShipMethodID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderHeader_VendorID",
            //    schema: "Purchasing",
            //    table: "PurchaseOrderHeader",
            //    column: "VendorID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_ShipMethod_Name",
            //    schema: "Purchasing",
            //    table: "ShipMethod",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_ShipMethod_rowguid",
            //    schema: "Purchasing",
            //    table: "ShipMethod",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Vendor_AccountNumber",
            //    schema: "Purchasing",
            //    table: "Vendor",
            //    column: "AccountNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CountryRegionCurrency_CurrencyCode",
            //    schema: "Sales",
            //    table: "CountryRegionCurrency",
            //    column: "CurrencyCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_CreditCard_CardNumber",
            //    schema: "Sales",
            //    table: "CreditCard",
            //    column: "CardNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Currency_Name",
            //    schema: "Sales",
            //    table: "Currency",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CurrencyRate_FromCurrencyCode",
            //    schema: "Sales",
            //    table: "CurrencyRate",
            //    column: "FromCurrencyCode");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CurrencyRate_ToCurrencyCode",
            //    schema: "Sales",
            //    table: "CurrencyRate",
            //    column: "ToCurrencyCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode",
            //    schema: "Sales",
            //    table: "CurrencyRate",
            //    columns: new[] { "CurrencyRateDate", "FromCurrencyCode", "ToCurrencyCode" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_Customer_AccountNumber",
            //    schema: "Sales",
            //    table: "Customer",
            //    column: "AccountNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Customer_PersonID",
            //    schema: "Sales",
            //    table: "Customer",
            //    column: "PersonID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Customer_rowguid",
            //    schema: "Sales",
            //    table: "Customer",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Customer_StoreID",
            //    schema: "Sales",
            //    table: "Customer",
            //    column: "StoreID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Customer_TerritoryID",
            //    schema: "Sales",
            //    table: "Customer",
            //    column: "TerritoryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PersonCreditCard_CreditCardID",
            //    schema: "Sales",
            //    table: "PersonCreditCard",
            //    column: "CreditCardID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderDetail_ProductID",
            //    schema: "Sales",
            //    table: "SalesOrderDetail",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesOrderDetail_rowguid",
            //    schema: "Sales",
            //    table: "SalesOrderDetail",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderDetail_SpecialOfferID_ProductID",
            //    schema: "Sales",
            //    table: "SalesOrderDetail",
            //    columns: new[] { "SpecialOfferID", "ProductID" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_BillToAddressID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "BillToAddressID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_CreditCardID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "CreditCardID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_CurrencyRateID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "CurrencyRateID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_CustomerID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "CustomerID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesOrderHeader_rowguid",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesOrderHeader_SalesOrderNumber",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "SalesOrderNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_SalesPersonID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "SalesPersonID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_ShipMethodID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "ShipMethodID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_ShipToAddressID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "ShipToAddressID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeader_TerritoryID",
            //    schema: "Sales",
            //    table: "SalesOrderHeader",
            //    column: "TerritoryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesOrderHeaderSalesReason_SalesReasonID",
            //    schema: "Sales",
            //    table: "SalesOrderHeaderSalesReason",
            //    column: "SalesReasonID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesPerson_rowguid",
            //    schema: "Sales",
            //    table: "SalesPerson",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesPerson_TerritoryID",
            //    schema: "Sales",
            //    table: "SalesPerson",
            //    column: "TerritoryID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesPersonQuotaHistory_rowguid",
            //    schema: "Sales",
            //    table: "SalesPersonQuotaHistory",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesTaxRate_rowguid",
            //    schema: "Sales",
            //    table: "SalesTaxRate",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesTaxRate_StateProvinceID_TaxType",
            //    schema: "Sales",
            //    table: "SalesTaxRate",
            //    columns: new[] { "StateProvinceID", "TaxType" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesTerritory_CountryRegionCode",
            //    schema: "Sales",
            //    table: "SalesTerritory",
            //    column: "CountryRegionCode");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesTerritory_Name",
            //    schema: "Sales",
            //    table: "SalesTerritory",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesTerritory_rowguid",
            //    schema: "Sales",
            //    table: "SalesTerritory",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "AK_SalesTerritoryHistory_rowguid",
            //    schema: "Sales",
            //    table: "SalesTerritoryHistory",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SalesTerritoryHistory_TerritoryID",
            //    schema: "Sales",
            //    table: "SalesTerritoryHistory",
            //    column: "TerritoryID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ShoppingCartItem_ProductID",
            //    schema: "Sales",
            //    table: "ShoppingCartItem",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ShoppingCartItem_ShoppingCartID_ProductID",
            //    schema: "Sales",
            //    table: "ShoppingCartItem",
            //    columns: new[] { "ShoppingCartID", "ProductID" });

            //migrationBuilder.CreateIndex(
            //    name: "AK_SpecialOffer_rowguid",
            //    schema: "Sales",
            //    table: "SpecialOffer",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SpecialOfferProduct_ProductID",
            //    schema: "Sales",
            //    table: "SpecialOfferProduct",
            //    column: "ProductID");

            //migrationBuilder.CreateIndex(
            //    name: "AK_SpecialOfferProduct_rowguid",
            //    schema: "Sales",
            //    table: "SpecialOfferProduct",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "PXML_Store_Demographics",
            //    schema: "Sales",
            //    table: "Store",
            //    column: "Demographics");

            //migrationBuilder.CreateIndex(
            //    name: "AK_Store_rowguid",
            //    schema: "Sales",
            //    table: "Store",
            //    column: "rowguid",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Store_SalesPersonID",
            //    schema: "Sales",
            //    table: "Store",
            //    column: "SalesPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "__MigrationHistory");

            //migrationBuilder.DropTable(
            //    name: "AWBuildVersion");

            //migrationBuilder.DropTable(
            //    name: "DatabaseLog");

            //migrationBuilder.DropTable(
            //    name: "ErrorLog");

            //migrationBuilder.DropTable(
            //    name: "Logs");

            //migrationBuilder.DropTable(
            //    name: "EmployeeDepartmentHistory",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "EmployeePayHistory",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "JobCandidate",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "BusinessEntityAddress",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "BusinessEntityContact",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "EmailAddress",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "Password",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "PersonPhone",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "BillOfMaterials",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductCostHistory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductInventory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductListPriceHistory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductModelIllustration",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductModelProductDescriptionCulture",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductProductPhoto",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductReview",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "TransactionHistory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "TransactionHistoryArchive",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "WorkOrderRouting",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductVendor",
            //    schema: "Purchasing");

            //migrationBuilder.DropTable(
            //    name: "PurchaseOrderDetail",
            //    schema: "Purchasing");

            //migrationBuilder.DropTable(
            //    name: "CountryRegionCurrency",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "PersonCreditCard",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesOrderDetail",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesOrderHeaderSalesReason",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesPersonQuotaHistory",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesTaxRate",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesTerritoryHistory",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "ShoppingCartItem",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Department",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "Shift",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "AddressType",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "ContactType",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "PhoneNumberType",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "Illustration",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "Culture",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductDescription",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductPhoto",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "Location",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "WorkOrder",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "PurchaseOrderHeader",
            //    schema: "Purchasing");

            //migrationBuilder.DropTable(
            //    name: "SpecialOfferProduct",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesOrderHeader",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "SalesReason",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "ScrapReason",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "Vendor",
            //    schema: "Purchasing");

            //migrationBuilder.DropTable(
            //    name: "Product",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "SpecialOffer",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Address",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "CreditCard",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "CurrencyRate",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Customer",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "ShipMethod",
            //    schema: "Purchasing");

            //migrationBuilder.DropTable(
            //    name: "ProductModel",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "ProductSubcategory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "UnitMeasure",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "StateProvince",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "Currency",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Store",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "ProductCategory",
            //    schema: "Production");

            //migrationBuilder.DropTable(
            //    name: "SalesPerson",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Employee",
            //    schema: "HumanResources");

            //migrationBuilder.DropTable(
            //    name: "SalesTerritory",
            //    schema: "Sales");

            //migrationBuilder.DropTable(
            //    name: "Person",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "CountryRegion",
            //    schema: "Person");

            //migrationBuilder.DropTable(
            //    name: "BusinessEntity",
            //    schema: "Person");
        }
    }
}
