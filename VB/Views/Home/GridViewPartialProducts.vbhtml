﻿@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvProducts"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialProducts"}

            settings.KeyFieldName = "ProductID"

            settings.Columns.Add("ProductID")
            settings.Columns.Add("ProductName")
            settings.Columns.Add("CategoryID")
            settings.Columns.Add("UnitPrice")

            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
    
    End Sub).Bind(Model).GetHtml()