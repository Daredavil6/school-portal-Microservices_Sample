
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.Configurations;
using SchoolPortal.Common.Models.dboSchema;
using System;
using System.Collections.Generic;
namespace SchoolPortal.Common.Models;

public partial class SchoolPortalContext : DbContext
{
    public SchoolPortalContext()
    {
    }

    public SchoolPortalContext(DbContextOptions<SchoolPortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssesmentMaster> AssesmentMasters { get; set; }

    public virtual DbSet<AttendanceReasonMaster> AttendanceReasonMasters { get; set; }

    public virtual DbSet<AuthorMaster> AuthorMasters { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<BillMaster> BillMasters { get; set; }

    public virtual DbSet<BloodGroupMaster> BloodGroupMasters { get; set; }

    public virtual DbSet<BookCategoryMaster> BookCategoryMasters { get; set; }

    public virtual DbSet<BookMaster> BookMasters { get; set; }

    public virtual DbSet<BookTransactionDetail> BookTransactionDetails { get; set; }

    public virtual DbSet<BookTransactionType> BookTransactionTypes { get; set; }

    public virtual DbSet<BookTypeMaster> BookTypeMasters { get; set; }

    public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }

    public virtual DbSet<CityMaster> CityMasters { get; set; }

    public virtual DbSet<ClassMaster> ClassMasters { get; set; }

    public virtual DbSet<ClassSMSTasksDetail> ClassSMSTasksDetails { get; set; }

    public virtual DbSet<ClassScholasticDetail> ClassScholasticDetails { get; set; }

    public virtual DbSet<ClassScholasticDetailHistory> ClassScholasticDetailHistories { get; set; }

    public virtual DbSet<ClassSectionDetail> ClassSectionDetails { get; set; }

    public virtual DbSet<ClassSubjectDetail> ClassSubjectDetails { get; set; }

    public virtual DbSet<ClassSubjectDetailHistory> ClassSubjectDetailHistories { get; set; }

    public virtual DbSet<CleanerMaster> CleanerMasters { get; set; }

    public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }

    public virtual DbSet<CountryMaster> CountryMasters { get; set; }

    public virtual DbSet<DeptDesigDetail> DeptDesigDetails { get; set; }

    public virtual DbSet<DeptMaster> DeptMasters { get; set; }

    public virtual DbSet<DesigGradeDetail> DesigGradeDetails { get; set; }

    public virtual DbSet<DesigMaster> DesigMasters { get; set; }

    public virtual DbSet<DriverMaster> DriverMasters { get; set; }

    public virtual DbSet<EmpAttendanceDetail> EmpAttendanceDetails { get; set; }

    public virtual DbSet<EmpAttendanceDetailsHistory> EmpAttendanceDetailsHistories { get; set; }

    public virtual DbSet<EmpCatLeaveDetailsHistory> EmpCatLeaveDetailsHistories { get; set; }

    public virtual DbSet<EmpDocumentDetail> EmpDocumentDetails { get; set; }

    public virtual DbSet<EmpLeaveAvailDetail> EmpLeaveAvailDetails { get; set; }

    public virtual DbSet<EmpLeaveDetail> EmpLeaveDetails { get; set; }

    public virtual DbSet<EmpLeaveDetailsHistory> EmpLeaveDetailsHistories { get; set; }

    public virtual DbSet<EmpMaster> EmpMasters { get; set; }

    public virtual DbSet<EmpProfQualIdetail> EmpProfQualIdetails { get; set; }

    public virtual DbSet<EmpSalaryDetail> EmpSalaryDetails { get; set; }

    public virtual DbSet<EmpSalaryDetailsHistory> EmpSalaryDetailsHistories { get; set; }

    public virtual DbSet<EmpSalaryMaster> EmpSalaryMasters { get; set; }

    public virtual DbSet<EmpSalaryMasterHistory> EmpSalaryMasterHistories { get; set; }

    public virtual DbSet<EmpSalaryStructureDetail> EmpSalaryStructureDetails { get; set; }

    public virtual DbSet<EmpSalaryStructureDetailsHistory> EmpSalaryStructureDetailsHistories { get; set; }

    public virtual DbSet<EmpTypeMaster> EmpTypeMasters { get; set; }

    public virtual DbSet<EmployeeCatLeaveDetail> EmployeeCatLeaveDetails { get; set; }

    public virtual DbSet<EmployeeCategoryMaster> EmployeeCategoryMasters { get; set; }

    public virtual DbSet<ExamCategoryMaster> ExamCategoryMasters { get; set; }

    public virtual DbSet<ExamUnitMaster> ExamUnitMasters { get; set; }

    public virtual DbSet<ExpenseCategoryMaster> ExpenseCategoryMasters { get; set; }

    public virtual DbSet<FeeClassDetail> FeeClassDetails { get; set; }

    public virtual DbSet<FeeClassDetailsHistory> FeeClassDetailsHistories { get; set; }

    public virtual DbSet<FeesCategoryMaster> FeesCategoryMasters { get; set; }

    public virtual DbSet<FeesDiscountCategoryMaster> FeesDiscountCategoryMasters { get; set; }

    public virtual DbSet<GenderMaster> GenderMasters { get; set; }

    public virtual DbSet<GradeMaster> GradeMasters { get; set; }

    public virtual DbSet<HolidayClassDetail> HolidayClassDetails { get; set; }

    public virtual DbSet<HolidayDeptDetail> HolidayDeptDetails { get; set; }

    public virtual DbSet<HolidayMaster> HolidayMasters { get; set; }

    public virtual DbSet<HolidayTypeMaster> HolidayTypeMasters { get; set; }

    public virtual DbSet<InventoryMaster> InventoryMasters { get; set; }

    public virtual DbSet<ItemLocationMaster> ItemLocationMasters { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<ItemTypeMaster> ItemTypeMasters { get; set; }

    public virtual DbSet<LeaveStatusMaster> LeaveStatusMasters { get; set; }

    public virtual DbSet<LeaveTypeMaster> LeaveTypeMasters { get; set; }

    public virtual DbSet<LocationMaster> LocationMasters { get; set; }

    public virtual DbSet<MarksGradeMaster> MarksGradeMasters { get; set; }

    public virtual DbSet<NotificationReceiverMaster> NotificationReceiverMasters { get; set; }

    public virtual DbSet<ParentMaster> ParentMasters { get; set; }

    public virtual DbSet<PaymentModeMaster> PaymentModeMasters { get; set; }

    public virtual DbSet<Privilege> Privileges { get; set; }

    public virtual DbSet<ProfessionMaster> ProfessionMasters { get; set; }

    public virtual DbSet<PublisherMaster> PublisherMasters { get; set; }

    public virtual DbSet<QualificationMaster> QualificationMasters { get; set; }

    public virtual DbSet<RegistrationMaster> RegistrationMasters { get; set; }

    public virtual DbSet<ReligionMaster> ReligionMasters { get; set; }

    public virtual DbSet<RoleMaster> RoleMasters { get; set; }

    public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }

    public virtual DbSet<RouteDetail> RouteDetails { get; set; }

    public virtual DbSet<RouteMaster> RouteMasters { get; set; }

    public virtual DbSet<RouteStopDetail> RouteStopDetails { get; set; }

    public virtual DbSet<SMSTask> SMSTasks { get; set; }

    public virtual DbSet<SMSTaskHistory> SMSTaskHistories { get; set; }

    public virtual DbSet<SMSTaskSchedule> SMSTaskSchedules { get; set; }

    public virtual DbSet<SMSTaskSmtpDetail> SMSTaskSmtpDetails { get; set; }

    public virtual DbSet<SMSTaskStatusMaster> SMSTaskStatusMasters { get; set; }

    public virtual DbSet<SalaryDesigGradeDetail> SalaryDesigGradeDetails { get; set; }

    public virtual DbSet<SalaryDesigGradeDetailsHistory> SalaryDesigGradeDetailsHistories { get; set; }

    public virtual DbSet<SalaryHeadMaster> SalaryHeadMasters { get; set; }

    public virtual DbSet<ScholasticMaster> ScholasticMasters { get; set; }

    public virtual DbSet<ScholasticMasterHistory> ScholasticMasterHistories { get; set; }

    public virtual DbSet<ScholasticUnitDetail> ScholasticUnitDetails { get; set; }

    public virtual DbSet<ScholasticUnitDetailHistory> ScholasticUnitDetailHistories { get; set; }

    public virtual DbSet<SchoolContactMaster> SchoolContactMasters { get; set; }

    public virtual DbSet<SchoolMaster> SchoolMasters { get; set; }

    public virtual DbSet<SectionMaster> SectionMasters { get; set; }

    public virtual DbSet<SessionMaster> SessionMasters { get; set; }

    public virtual DbSet<SmtpDetail> SmtpDetails { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<StudentAchievement> StudentAchievements { get; set; }

    public virtual DbSet<StudentAttendanceDetail> StudentAttendanceDetails { get; set; }

    public virtual DbSet<StudentAttendanceDetailsHistory> StudentAttendanceDetailsHistories { get; set; }

    public virtual DbSet<StudentCommentDetail> StudentCommentDetails { get; set; }

    public virtual DbSet<StudentCommentDetailsHistory> StudentCommentDetailsHistories { get; set; }

    public virtual DbSet<StudentFeeDetail> StudentFeeDetails { get; set; }

    public virtual DbSet<StudentFeeDetailsHistory> StudentFeeDetailsHistories { get; set; }

    public virtual DbSet<StudentGradeDetail> StudentGradeDetails { get; set; }

    public virtual DbSet<StudentGradeDetailsHistory> StudentGradeDetailsHistories { get; set; }

    public virtual DbSet<StudentMarksDetail> StudentMarksDetails { get; set; }

    public virtual DbSet<StudentMarksDetailsHistory> StudentMarksDetailsHistories { get; set; }

    public virtual DbSet<StudentMaster> StudentMasters { get; set; }

    public virtual DbSet<StudentMasterHistory> StudentMasterHistories { get; set; }

    public virtual DbSet<StudentReportCardDetail> StudentReportCardDetails { get; set; }

    public virtual DbSet<StudentReportCardDetailsHistory> StudentReportCardDetailsHistories { get; set; }

    public virtual DbSet<StudentReportCardMaster> StudentReportCardMasters { get; set; }

    public virtual DbSet<StudentReportCardMasterHistory> StudentReportCardMasterHistories { get; set; }

    public virtual DbSet<SubjectCategoryDetail> SubjectCategoryDetails { get; set; }

    public virtual DbSet<SubjectCategoryDetailsHistory> SubjectCategoryDetailsHistories { get; set; }

    public virtual DbSet<SubjectMaster> SubjectMasters { get; set; }

    public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }

    public virtual DbSet<TeacherClassDetail> TeacherClassDetails { get; set; }

    public virtual DbSet<TeacherDocumentDetail> TeacherDocumentDetails { get; set; }

    public virtual DbSet<TeacherMaster> TeacherMasters { get; set; }

    public virtual DbSet<TeacherQualificationDetail> TeacherQualificationDetails { get; set; }

    public virtual DbSet<TeacherSectionDetail> TeacherSectionDetails { get; set; }

    public virtual DbSet<TeacherSubjectDetail> TeacherSubjectDetails { get; set; }

    public virtual DbSet<TimeTableClassPeriodDetail> TimeTableClassPeriodDetails { get; set; }

    public virtual DbSet<TimeTableClassPeriodDetailsHistory> TimeTableClassPeriodDetailsHistories { get; set; }

    public virtual DbSet<TimeTableDetailsHistory> TimeTableDetailsHistories { get; set; }

    public virtual DbSet<TimeTablePeriodMaster> TimeTablePeriodMasters { get; set; }

    public virtual DbSet<TimeTablePeriodMasterHistory> TimeTablePeriodMasterHistories { get; set; }

    public virtual DbSet<TimeTableSession> TimeTableSessions { get; set; }

    public virtual DbSet<TimeTableSetupDetail> TimeTableSetupDetails { get; set; }

    public virtual DbSet<TimeTableSetupDetailsHistory> TimeTableSetupDetailsHistories { get; set; }

    public virtual DbSet<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistories { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<VehicleExpenseDetail> VehicleExpenseDetails { get; set; }

    public virtual DbSet<VehicleMaster> VehicleMasters { get; set; }

    public virtual DbSet<VendorMaster> VendorMasters { get; set; }

    public virtual DbSet<VisitorMaster> VisitorMasters { get; set; }

    public virtual DbSet<VoucherMaster> VoucherMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=SAGAR\\SQL2022;Initial Catalog=SchoolPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AssesmentMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.AttendanceReasonMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.AuthorMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BillDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BillMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BloodGroupMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BookCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BookMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BookTransactionDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BookTransactionTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BookTypeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CityMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassSMSTasksDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassScholasticDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassScholasticDetailHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassSectionDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassSubjectDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ClassSubjectDetailHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CleanerMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CompanyMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CountryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DeptDesigDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DeptMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DesigGradeDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DesigMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DriverMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpAttendanceDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpAttendanceDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpCatLeaveDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpDocumentDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpLeaveAvailDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpLeaveDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpLeaveDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpProfQualIdetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryMasterHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryStructureDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpSalaryStructureDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmpTypeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeCatLeaveDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ExamCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ExamUnitMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ExpenseCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.FeeClassDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.FeeClassDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.FeesCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.FeesDiscountCategoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.GenderMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.GradeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.HolidayClassDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.HolidayDeptDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.HolidayMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.HolidayTypeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.InventoryMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ItemLocationMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ItemMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ItemTypeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.LeaveStatusMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.LeaveTypeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.LocationMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MarksGradeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.NotificationReceiverMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ParentMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PaymentModeMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PrivilegeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProfessionMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PublisherMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.QualificationMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RegistrationMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ReligionMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RoleMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RolePrivilegeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RouteDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RouteMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RouteStopDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SMSTaskConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SMSTaskHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SMSTaskScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SMSTaskSmtpDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SMSTaskStatusMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalaryDesigGradeDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalaryDesigGradeDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalaryHeadMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ScholasticMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ScholasticMasterHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ScholasticUnitDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ScholasticUnitDetailHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SchoolContactMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SchoolMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SectionMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SessionMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SmtpDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StateMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentAchievementConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentAttendanceDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentAttendanceDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentCommentDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentCommentDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentFeeDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentFeeDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentGradeDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentGradeDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentMarksDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentMarksDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentMasterHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentReportCardDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentReportCardDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentReportCardMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentReportCardMasterHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SubjectCategoryDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SubjectCategoryDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SubjectMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SupplierMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherClassDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherDocumentDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherQualificationDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherSectionDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TeacherSubjectDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableClassPeriodDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableClassPeriodDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTablePeriodMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTablePeriodMasterHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableSessionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableSetupDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableSetupDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TimeTableSubstitutionDetailsHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UserDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VehicleExpenseDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VehicleMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VendorMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VisitorMasterConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VoucherMasterConfiguration());

        OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

