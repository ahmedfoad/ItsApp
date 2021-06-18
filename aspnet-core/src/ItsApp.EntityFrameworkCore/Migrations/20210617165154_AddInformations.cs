using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ItsApp.Migrations
{
    public partial class AddInformations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId",
                table: "AbpWebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookSubscriptions",
                table: "AbpWebhookSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookSendAttempts",
                table: "AbpWebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookEvents",
                table: "AbpWebhookEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicPropertyValues",
                table: "AbpDynamicPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicProperties",
                table: "AbpDynamicProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicEntityPropertyValues",
                table: "AbpDynamicEntityPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicEntityProperties",
                table: "AbpDynamicEntityProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.EnsureSchema(
                name: "Infrastructure");

            migrationBuilder.EnsureSchema(
                name: "Core");

            migrationBuilder.RenameTable(
                name: "AbpWebhookSubscriptions",
                newName: "WebhookSubscriptions",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpWebhookSendAttempts",
                newName: "WebhookSendAttempts",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpWebhookEvents",
                newName: "WebhookEvents",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "UserTokens",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Users",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "UserRoles",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "UserOrganizationUnits",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserNotifications",
                newName: "UserNotifications",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "UserLogins",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserLoginAttempts",
                newName: "UserLoginAttempts",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "UserClaims",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpUserAccounts",
                newName: "UserAccounts",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "Tenants",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpTenantNotifications",
                newName: "TenantNotifications",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Settings",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Roles",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "RoleClaims",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Permissions",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "OrganizationUnits",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnitRoles",
                newName: "OrganizationUnitRoles",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "NotificationSubscriptions",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpNotifications",
                newName: "Notifications",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpLanguageTexts",
                newName: "LanguageTexts",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpLanguages",
                newName: "Languages",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "Features",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "EntityPropertyChanges",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpEntityChangeSets",
                newName: "EntityChangeSets",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "EntityChanges",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpEditions",
                newName: "Editions",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpDynamicPropertyValues",
                newName: "DynamicPropertyValues",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpDynamicProperties",
                newName: "DynamicProperties",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpDynamicEntityPropertyValues",
                newName: "DynamicEntityPropertyValues",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpDynamicEntityProperties",
                newName: "DynamicEntityProperties",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "BackgroundJobs",
                newSchema: "Infrastructure");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "AuditLogs",
                newSchema: "Infrastructure");

            migrationBuilder.RenameIndex(
                name: "IX_AbpWebhookSendAttempts_WebhookEventId",
                schema: "Infrastructure",
                table: "WebhookSendAttempts",
                newName: "IX_WebhookSendAttempts_WebhookEventId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_UserId",
                schema: "Infrastructure",
                table: "UserTokens",
                newName: "IX_UserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                schema: "Infrastructure",
                table: "UserTokens",
                newName: "IX_UserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                schema: "Infrastructure",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                schema: "Infrastructure",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                schema: "Infrastructure",
                table: "Users",
                newName: "IX_Users_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_DeleterUserId",
                schema: "Infrastructure",
                table: "Users",
                newName: "IX_Users_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_CreatorUserId",
                schema: "Infrastructure",
                table: "Users",
                newName: "IX_Users_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_UserId",
                schema: "Infrastructure",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                schema: "Infrastructure",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                schema: "Infrastructure",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                schema: "Infrastructure",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                schema: "Infrastructure",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                schema: "Infrastructure",
                table: "UserNotifications",
                newName: "IX_UserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_UserId",
                schema: "Infrastructure",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                schema: "Infrastructure",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                schema: "Infrastructure",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                schema: "Infrastructure",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                schema: "Infrastructure",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                schema: "Infrastructure",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                schema: "Infrastructure",
                table: "UserClaims",
                newName: "IX_UserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_UserName",
                schema: "Infrastructure",
                table: "UserAccounts",
                newName: "IX_UserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                schema: "Infrastructure",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                schema: "Infrastructure",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                schema: "Infrastructure",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                schema: "Infrastructure",
                table: "UserAccounts",
                newName: "IX_UserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_TenancyName",
                schema: "Infrastructure",
                table: "Tenants",
                newName: "IX_Tenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                schema: "Infrastructure",
                table: "Tenants",
                newName: "IX_Tenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_EditionId",
                schema: "Infrastructure",
                table: "Tenants",
                newName: "IX_Tenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_DeleterUserId",
                schema: "Infrastructure",
                table: "Tenants",
                newName: "IX_Tenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_CreatorUserId",
                schema: "Infrastructure",
                table: "Tenants",
                newName: "IX_Tenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                schema: "Infrastructure",
                table: "TenantNotifications",
                newName: "IX_TenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_UserId",
                schema: "Infrastructure",
                table: "Settings",
                newName: "IX_Settings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_TenantId_Name_UserId",
                schema: "Infrastructure",
                table: "Settings",
                newName: "IX_Settings_TenantId_Name_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                schema: "Infrastructure",
                table: "Roles",
                newName: "IX_Roles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                schema: "Infrastructure",
                table: "Roles",
                newName: "IX_Roles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_DeleterUserId",
                schema: "Infrastructure",
                table: "Roles",
                newName: "IX_Roles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_CreatorUserId",
                schema: "Infrastructure",
                table: "Roles",
                newName: "IX_Roles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                schema: "Infrastructure",
                table: "RoleClaims",
                newName: "IX_RoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                schema: "Infrastructure",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_UserId",
                schema: "Infrastructure",
                table: "Permissions",
                newName: "IX_Permissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                schema: "Infrastructure",
                table: "Permissions",
                newName: "IX_Permissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_RoleId",
                schema: "Infrastructure",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                schema: "Infrastructure",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                schema: "Infrastructure",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnitRoles_TenantId_RoleId",
                schema: "Infrastructure",
                table: "OrganizationUnitRoles",
                newName: "IX_OrganizationUnitRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId",
                schema: "Infrastructure",
                table: "OrganizationUnitRoles",
                newName: "IX_OrganizationUnitRoles_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "Infrastructure",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "Infrastructure",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                schema: "Infrastructure",
                table: "LanguageTexts",
                newName: "IX_LanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                schema: "Infrastructure",
                table: "Languages",
                newName: "IX_Languages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                schema: "Infrastructure",
                table: "Features",
                newName: "IX_Features_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                schema: "Infrastructure",
                table: "Features",
                newName: "IX_Features_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                schema: "Infrastructure",
                table: "EntityPropertyChanges",
                newName: "IX_EntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_UserId",
                schema: "Infrastructure",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_Reason",
                schema: "Infrastructure",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
                schema: "Infrastructure",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
                schema: "Infrastructure",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityChangeSetId",
                schema: "Infrastructure",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicPropertyValues_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicPropertyValues",
                newName: "IX_DynamicPropertyValues_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicProperties_PropertyName_TenantId",
                schema: "Infrastructure",
                table: "DynamicProperties",
                newName: "IX_DynamicProperties_PropertyName_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityPropertyValues",
                newName: "IX_DynamicEntityPropertyValues_DynamicEntityPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                schema: "Infrastructure",
                table: "DynamicEntityProperties",
                newName: "IX_DynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityProperties_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityProperties",
                newName: "IX_DynamicEntityProperties_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                schema: "Infrastructure",
                table: "BackgroundJobs",
                newName: "IX_BackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                schema: "Infrastructure",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                schema: "Infrastructure",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                schema: "Infrastructure",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookSubscriptions",
                schema: "Infrastructure",
                table: "WebhookSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookSendAttempts",
                schema: "Infrastructure",
                table: "WebhookSendAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookEvents",
                schema: "Infrastructure",
                table: "WebhookEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "Infrastructure",
                table: "UserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "Infrastructure",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Infrastructure",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "Infrastructure",
                table: "UserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNotifications",
                schema: "Infrastructure",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "Infrastructure",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "Infrastructure",
                table: "UserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "Infrastructure",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                schema: "Infrastructure",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                schema: "Infrastructure",
                table: "Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "Infrastructure",
                table: "TenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                schema: "Infrastructure",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "Infrastructure",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Infrastructure",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                schema: "Infrastructure",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "Infrastructure",
                table: "OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnitRoles",
                schema: "Infrastructure",
                table: "OrganizationUnitRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "Infrastructure",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                schema: "Infrastructure",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "Infrastructure",
                table: "LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                schema: "Infrastructure",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                schema: "Infrastructure",
                table: "Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "Infrastructure",
                table: "EntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "Infrastructure",
                table: "EntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChanges",
                schema: "Infrastructure",
                table: "EntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                schema: "Infrastructure",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicPropertyValues",
                schema: "Infrastructure",
                table: "DynamicPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicProperties",
                schema: "Infrastructure",
                table: "DynamicProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicEntityPropertyValues",
                schema: "Infrastructure",
                table: "DynamicEntityPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicEntityProperties",
                schema: "Infrastructure",
                table: "DynamicEntityProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "Infrastructure",
                table: "BackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditLogs",
                schema: "Infrastructure",
                table: "AuditLogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Informations",
                schema: "Core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepIndex = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicEntityProperties_DynamicProperties_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityProperties",
                column: "DynamicPropertyId",
                principalSchema: "Infrastructure",
                principalTable: "DynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicEntityPropertyValues_DynamicEntityProperties_DynamicEntityPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId",
                principalSchema: "Infrastructure",
                principalTable: "DynamicEntityProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicPropertyValues_DynamicProperties_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicPropertyValues",
                column: "DynamicPropertyId",
                principalSchema: "Infrastructure",
                principalTable: "DynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "Infrastructure",
                table: "EntityChanges",
                column: "EntityChangeSetId",
                principalSchema: "Infrastructure",
                principalTable: "EntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "Infrastructure",
                table: "EntityPropertyChanges",
                column: "EntityChangeId",
                principalSchema: "Infrastructure",
                principalTable: "EntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "Infrastructure",
                table: "Features",
                column: "EditionId",
                principalSchema: "Infrastructure",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "Infrastructure",
                table: "OrganizationUnits",
                column: "ParentId",
                principalSchema: "Infrastructure",
                principalTable: "OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "Infrastructure",
                table: "Permissions",
                column: "RoleId",
                principalSchema: "Infrastructure",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "Infrastructure",
                table: "Permissions",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "Infrastructure",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "Infrastructure",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Roles",
                column: "CreatorUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Roles",
                column: "DeleterUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Roles",
                column: "LastModifierUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "Infrastructure",
                table: "Settings",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "Infrastructure",
                table: "Tenants",
                column: "EditionId",
                principalSchema: "Infrastructure",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Tenants",
                column: "CreatorUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Tenants",
                column: "DeleterUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Tenants",
                column: "LastModifierUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "Infrastructure",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "Infrastructure",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Infrastructure",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Users",
                column: "CreatorUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Users",
                column: "DeleterUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Users",
                column: "LastModifierUserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "Infrastructure",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "Infrastructure",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WebhookSendAttempts_WebhookEvents_WebhookEventId",
                schema: "Infrastructure",
                table: "WebhookSendAttempts",
                column: "WebhookEventId",
                principalSchema: "Infrastructure",
                principalTable: "WebhookEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicEntityProperties_DynamicProperties_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_DynamicEntityPropertyValues_DynamicEntityProperties_DynamicEntityPropertyId",
                schema: "Infrastructure",
                table: "DynamicEntityPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_DynamicPropertyValues_DynamicProperties_DynamicPropertyId",
                schema: "Infrastructure",
                table: "DynamicPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "Infrastructure",
                table: "EntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "Infrastructure",
                table: "EntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "Infrastructure",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "Infrastructure",
                table: "OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "Infrastructure",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "Infrastructure",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "Infrastructure",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "Infrastructure",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "Infrastructure",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "Infrastructure",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "Infrastructure",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Infrastructure",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "Infrastructure",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "Infrastructure",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "Infrastructure",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "Infrastructure",
                table: "UserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_WebhookSendAttempts_WebhookEvents_WebhookEventId",
                schema: "Infrastructure",
                table: "WebhookSendAttempts");

            migrationBuilder.DropTable(
                name: "Informations",
                schema: "Core");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookSubscriptions",
                schema: "Infrastructure",
                table: "WebhookSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookSendAttempts",
                schema: "Infrastructure",
                table: "WebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookEvents",
                schema: "Infrastructure",
                table: "WebhookEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "Infrastructure",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "Infrastructure",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Infrastructure",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "Infrastructure",
                table: "UserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNotifications",
                schema: "Infrastructure",
                table: "UserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "Infrastructure",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "Infrastructure",
                table: "UserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "Infrastructure",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                schema: "Infrastructure",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                schema: "Infrastructure",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "Infrastructure",
                table: "TenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                schema: "Infrastructure",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "Infrastructure",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Infrastructure",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                schema: "Infrastructure",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "Infrastructure",
                table: "OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnitRoles",
                schema: "Infrastructure",
                table: "OrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "Infrastructure",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                schema: "Infrastructure",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "Infrastructure",
                table: "LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                schema: "Infrastructure",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                schema: "Infrastructure",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "Infrastructure",
                table: "EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "Infrastructure",
                table: "EntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChanges",
                schema: "Infrastructure",
                table: "EntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                schema: "Infrastructure",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicPropertyValues",
                schema: "Infrastructure",
                table: "DynamicPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicProperties",
                schema: "Infrastructure",
                table: "DynamicProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicEntityPropertyValues",
                schema: "Infrastructure",
                table: "DynamicEntityPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicEntityProperties",
                schema: "Infrastructure",
                table: "DynamicEntityProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "Infrastructure",
                table: "BackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditLogs",
                schema: "Infrastructure",
                table: "AuditLogs");

            migrationBuilder.RenameTable(
                name: "WebhookSubscriptions",
                schema: "Infrastructure",
                newName: "AbpWebhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "WebhookSendAttempts",
                schema: "Infrastructure",
                newName: "AbpWebhookSendAttempts");

            migrationBuilder.RenameTable(
                name: "WebhookEvents",
                schema: "Infrastructure",
                newName: "AbpWebhookEvents");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Infrastructure",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Infrastructure",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Infrastructure",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "UserOrganizationUnits",
                schema: "Infrastructure",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "UserNotifications",
                schema: "Infrastructure",
                newName: "AbpUserNotifications");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Infrastructure",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "UserLoginAttempts",
                schema: "Infrastructure",
                newName: "AbpUserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Infrastructure",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                schema: "Infrastructure",
                newName: "AbpUserAccounts");

            migrationBuilder.RenameTable(
                name: "Tenants",
                schema: "Infrastructure",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "TenantNotifications",
                schema: "Infrastructure",
                newName: "AbpTenantNotifications");

            migrationBuilder.RenameTable(
                name: "Settings",
                schema: "Infrastructure",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "Infrastructure",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Infrastructure",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Permissions",
                schema: "Infrastructure",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "OrganizationUnits",
                schema: "Infrastructure",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "OrganizationUnitRoles",
                schema: "Infrastructure",
                newName: "AbpOrganizationUnitRoles");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                schema: "Infrastructure",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                schema: "Infrastructure",
                newName: "AbpNotifications");

            migrationBuilder.RenameTable(
                name: "LanguageTexts",
                schema: "Infrastructure",
                newName: "AbpLanguageTexts");

            migrationBuilder.RenameTable(
                name: "Languages",
                schema: "Infrastructure",
                newName: "AbpLanguages");

            migrationBuilder.RenameTable(
                name: "Features",
                schema: "Infrastructure",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "EntityPropertyChanges",
                schema: "Infrastructure",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "EntityChangeSets",
                schema: "Infrastructure",
                newName: "AbpEntityChangeSets");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                schema: "Infrastructure",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "Editions",
                schema: "Infrastructure",
                newName: "AbpEditions");

            migrationBuilder.RenameTable(
                name: "DynamicPropertyValues",
                schema: "Infrastructure",
                newName: "AbpDynamicPropertyValues");

            migrationBuilder.RenameTable(
                name: "DynamicProperties",
                schema: "Infrastructure",
                newName: "AbpDynamicProperties");

            migrationBuilder.RenameTable(
                name: "DynamicEntityPropertyValues",
                schema: "Infrastructure",
                newName: "AbpDynamicEntityPropertyValues");

            migrationBuilder.RenameTable(
                name: "DynamicEntityProperties",
                schema: "Infrastructure",
                newName: "AbpDynamicEntityProperties");

            migrationBuilder.RenameTable(
                name: "BackgroundJobs",
                schema: "Infrastructure",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AuditLogs",
                schema: "Infrastructure",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_WebhookSendAttempts_WebhookEventId",
                table: "AbpWebhookSendAttempts",
                newName: "IX_AbpWebhookSendAttempts_WebhookEventId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedUserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LastModifierUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeleterUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatorUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                newName: "IX_AbpUserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_TenancyName",
                table: "AbpTenants",
                newName: "IX_AbpTenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_LastModifierUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_EditionId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_DeleterUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_CreatorUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                newName: "IX_AbpTenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_TenantId_Name_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_TenantId_Name_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_TenantId_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_LastModifierUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_DeleterUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_CreatorUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_UserId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_TenantId_Name",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnitRoles_TenantId_RoleId",
                table: "AbpOrganizationUnitRoles",
                newName: "IX_AbpOrganizationUnitRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnitRoles_TenantId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                newName: "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                newName: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_TenantId_Name",
                table: "AbpLanguages",
                newName: "IX_AbpLanguages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_TenantId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_EditionId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_EntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                newName: "IX_AbpEntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_UserId",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_Reason",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_CreationTime",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityChangeSetId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicPropertyValues_DynamicPropertyId",
                table: "AbpDynamicPropertyValues",
                newName: "IX_AbpDynamicPropertyValues_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicProperties_PropertyName_TenantId",
                table: "AbpDynamicProperties",
                newName: "IX_AbpDynamicProperties_PropertyName_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityPropertyValues_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues",
                newName: "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                table: "AbpDynamicEntityProperties",
                newName: "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties",
                newName: "IX_AbpDynamicEntityProperties_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                newName: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookSubscriptions",
                table: "AbpWebhookSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookSendAttempts",
                table: "AbpWebhookSendAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookEvents",
                table: "AbpWebhookEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicPropertyValues",
                table: "AbpDynamicPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicProperties",
                table: "AbpDynamicProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicEntityPropertyValues",
                table: "AbpDynamicEntityPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicEntityProperties",
                table: "AbpDynamicEntityProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties",
                column: "DynamicPropertyId",
                principalTable: "AbpDynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId",
                principalTable: "AbpDynamicEntityProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicPropertyValues",
                column: "DynamicPropertyId",
                principalTable: "AbpDynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges",
                column: "EntityChangeSetId",
                principalTable: "AbpEntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId",
                table: "AbpWebhookSendAttempts",
                column: "WebhookEventId",
                principalTable: "AbpWebhookEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
