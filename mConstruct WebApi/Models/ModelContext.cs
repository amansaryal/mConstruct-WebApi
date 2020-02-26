using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mConstruct_WebApi.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FttxTaskmaster1> FttxTaskmaster1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(CID=GTU_APP)(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dev-scan.ril.com)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=PLNGDEV)(SERVER=DEDICATED)));User ID=APP_FTTX;Password=fttx_182");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "APP_FTTX");

            modelBuilder.Entity<FttxTaskmaster1>(entity =>
            {
                entity.HasKey(e => e.Taskid);

                entity.ToTable("FTTX_TASKMASTER_1");

                entity.HasIndex(e => e.Objectid)
                    .HasName("R800_SDE_ROWID_UK")
                    .IsUnique();

                entity.HasIndex(e => e.Taskid)
                    .HasName("PK_TM_1")
                    .IsUnique();

                entity.Property(e => e.Taskid)
                    .HasColumnName("TASKID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Acceptordate)
                    .HasColumnName("ACCEPTORDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Appversion)
                    .HasColumnName("APPVERSION")
                    .HasMaxLength(5);

                entity.Property(e => e.Constructordate)
                    .HasColumnName("CONSTRUCTORDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Constructorid)
                    .HasColumnName("CONSTRUCTORID")
                    .HasMaxLength(10);

                entity.Property(e => e.Constructorname)
                    .HasColumnName("CONSTRUCTORNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Contractorcompany)
                    .HasColumnName("CONTRACTORCOMPANY")
                    .HasMaxLength(25);

                entity.Property(e => e.Contractordate)
                    .HasColumnName("CONTRACTORDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Contractorid)
                    .HasColumnName("CONTRACTORID")
                    .HasMaxLength(10);

                entity.Property(e => e.Contractorname)
                    .HasColumnName("CONTRACTORNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Csaid)
                    .HasColumnName("CSAID")
                    .HasMaxLength(50);

                entity.Property(e => e.Dsaid)
                    .HasColumnName("DSAID")
                    .HasMaxLength(50);

                entity.Property(e => e.Feederno).HasColumnName("FEEDERNO");

                entity.Property(e => e.Fsaid)
                    .HasColumnName("FSAID")
                    .HasMaxLength(50);

                entity.Property(e => e.Layer)
                    .HasColumnName("LAYER")
                    .HasMaxLength(50);

                entity.Property(e => e.Mduid)
                    .HasColumnName("MDUID")
                    .HasMaxLength(50);

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rev).HasColumnName("REV");

                entity.Property(e => e.Role)
                    .HasColumnName("ROLE")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.Tasktype)
                    .HasColumnName("TASKTYPE")
                    .HasMaxLength(50);
            });

            modelBuilder.HasSequence("APIREQUESTREFERENCE_AUDIT_ID");

            modelBuilder.HasSequence("APIREQUESTREFERENCE_ID");

            modelBuilder.HasSequence("APPLICATION_ERROR_LOG_SEQ");

            modelBuilder.HasSequence("B2O_INVENTORY_MODEL_B2O_ID");

            modelBuilder.HasSequence("CONTRACTER_ID_GEN_SEQ");

            modelBuilder.HasSequence("FSA_DESIGN_ID_SEQ");

            modelBuilder.HasSequence("FTTX_FSA_RESETDETAILS_SEQ");

            modelBuilder.HasSequence("FTTX_FSA_RESETDETAILS1_SEQ");

            modelBuilder.HasSequence("FTTXMCONSTUNIQUEID");

            modelBuilder.HasSequence("HIBERNATE_SEQUENCE");

            modelBuilder.HasSequence("ID_FSA_MIGRATION");

            modelBuilder.HasSequence("ID_OFFER_OCDE_MIGRATION");

            modelBuilder.HasSequence("ID_TASKMASTERHISTORY");

            modelBuilder.HasSequence("ID_TASKMASTERHISTORY_NEW");

            modelBuilder.HasSequence("INCR_OBJECTID");

            modelBuilder.HasSequence("INCR_TRANSMEDIA_MDU_OBJECTID");

            modelBuilder.HasSequence("INCR_WORKFORCE_ID");

            modelBuilder.HasSequence("K2_BOQ_DETAILS_SEQ");

            modelBuilder.HasSequence("K2_BUSSINESS_PLANNING_SEQ");

            modelBuilder.HasSequence("K2_MATCODE_DETAILS_SEQ");

            modelBuilder.HasSequence("LINK_TRACE_LOIDID");

            modelBuilder.HasSequence("LINK_TRACE_REQID");

            modelBuilder.HasSequence("MDRS_52A33$");

            modelBuilder.HasSequence("MIS_SCOPE_CONSTRUCTION_SEQ");

            modelBuilder.HasSequence("NE_B2O_SOLUTION_DATA_SEQ");

            modelBuilder.HasSequence("O2A_EXCEPTIONS_LOG_SEQ");

            modelBuilder.HasSequence("R10219");

            modelBuilder.HasSequence("R10220");

            modelBuilder.HasSequence("R10221");

            modelBuilder.HasSequence("R10241");

            modelBuilder.HasSequence("R1057");

            modelBuilder.HasSequence("R10570");

            modelBuilder.HasSequence("R10571");

            modelBuilder.HasSequence("R1064");

            modelBuilder.HasSequence("R10765");

            modelBuilder.HasSequence("R10815");

            modelBuilder.HasSequence("R10820");

            modelBuilder.HasSequence("R10822");

            modelBuilder.HasSequence("R10847");

            modelBuilder.HasSequence("R10857");

            modelBuilder.HasSequence("R10858");

            modelBuilder.HasSequence("R1091");

            modelBuilder.HasSequence("R10910");

            modelBuilder.HasSequence("R10964");

            modelBuilder.HasSequence("R12094");

            modelBuilder.HasSequence("R129462");

            modelBuilder.HasSequence("R131472");

            modelBuilder.HasSequence("R1332");

            modelBuilder.HasSequence("R1333");

            modelBuilder.HasSequence("R1334");

            modelBuilder.HasSequence("R1335");

            modelBuilder.HasSequence("R1336");

            modelBuilder.HasSequence("R1374");

            modelBuilder.HasSequence("R13745");

            modelBuilder.HasSequence("R13763");

            modelBuilder.HasSequence("R138424");

            modelBuilder.HasSequence("R144523");

            modelBuilder.HasSequence("R1455");

            modelBuilder.HasSequence("R148976");

            modelBuilder.HasSequence("R15880");

            modelBuilder.HasSequence("R16370");

            modelBuilder.HasSequence("R16548");

            modelBuilder.HasSequence("R16745");

            modelBuilder.HasSequence("R16746");

            modelBuilder.HasSequence("R17036");

            modelBuilder.HasSequence("R17038");

            modelBuilder.HasSequence("R17067");

            modelBuilder.HasSequence("R17304");

            modelBuilder.HasSequence("R2431");

            modelBuilder.HasSequence("R2522");

            modelBuilder.HasSequence("R2523");

            modelBuilder.HasSequence("R2524");

            modelBuilder.HasSequence("R2525");

            modelBuilder.HasSequence("R2544");

            modelBuilder.HasSequence("R2549");

            modelBuilder.HasSequence("R2651");

            modelBuilder.HasSequence("R2811");

            modelBuilder.HasSequence("R2812");

            modelBuilder.HasSequence("R2813");

            modelBuilder.HasSequence("R2814");

            modelBuilder.HasSequence("R2893");

            modelBuilder.HasSequence("R2915");

            modelBuilder.HasSequence("R29195");

            modelBuilder.HasSequence("R29290");

            modelBuilder.HasSequence("R29452");

            modelBuilder.HasSequence("R29453");

            modelBuilder.HasSequence("R29458");

            modelBuilder.HasSequence("R29459");

            modelBuilder.HasSequence("R29460");

            modelBuilder.HasSequence("R29461");

            modelBuilder.HasSequence("R29462");

            modelBuilder.HasSequence("R29535");

            modelBuilder.HasSequence("R30361");

            modelBuilder.HasSequence("R3450");

            modelBuilder.HasSequence("R3461");

            modelBuilder.HasSequence("R48366");

            modelBuilder.HasSequence("R58330");

            modelBuilder.HasSequence("R68574");

            modelBuilder.HasSequence("R68576");

            modelBuilder.HasSequence("R69194");

            modelBuilder.HasSequence("R69238");

            modelBuilder.HasSequence("R69252");

            modelBuilder.HasSequence("R69283");

            modelBuilder.HasSequence("R69298");

            modelBuilder.HasSequence("R69352");

            modelBuilder.HasSequence("R69616");

            modelBuilder.HasSequence("R70725");

            modelBuilder.HasSequence("R70764");

            modelBuilder.HasSequence("R70881");

            modelBuilder.HasSequence("R71912");

            modelBuilder.HasSequence("R7242");

            modelBuilder.HasSequence("R74084");

            modelBuilder.HasSequence("R7455");

            modelBuilder.HasSequence("R762");

            modelBuilder.HasSequence("R763");

            modelBuilder.HasSequence("R764");

            modelBuilder.HasSequence("R765");

            modelBuilder.HasSequence("R766");

            modelBuilder.HasSequence("R767");

            modelBuilder.HasSequence("R768");

            modelBuilder.HasSequence("R769");

            modelBuilder.HasSequence("R7703");

            modelBuilder.HasSequence("R771");

            modelBuilder.HasSequence("R772");

            modelBuilder.HasSequence("R773");

            modelBuilder.HasSequence("R774");

            modelBuilder.HasSequence("R7754");

            modelBuilder.HasSequence("R7755");

            modelBuilder.HasSequence("R776");

            modelBuilder.HasSequence("R777");

            modelBuilder.HasSequence("R779");

            modelBuilder.HasSequence("R786");

            modelBuilder.HasSequence("R791");

            modelBuilder.HasSequence("R7919");

            modelBuilder.HasSequence("R792");

            modelBuilder.HasSequence("R793");

            modelBuilder.HasSequence("R794");

            modelBuilder.HasSequence("R795");

            modelBuilder.HasSequence("R796");

            modelBuilder.HasSequence("R797");

            modelBuilder.HasSequence("R798");

            modelBuilder.HasSequence("R799");

            modelBuilder.HasSequence("R800");

            modelBuilder.HasSequence("R8013");

            modelBuilder.HasSequence("R8039");

            modelBuilder.HasSequence("R8233");

            modelBuilder.HasSequence("R8234");

            modelBuilder.HasSequence("R861");

            modelBuilder.HasSequence("R862");

            modelBuilder.HasSequence("R9292");

            modelBuilder.HasSequence("R9444");

            modelBuilder.HasSequence("SDE_LOGFILE_LID_GEN");

            modelBuilder.HasSequence("SEQ_BOUNDARY_MASTER");

            modelBuilder.HasSequence("SEQ_BUILDING_EQUIPMENT_MAPPING");

            modelBuilder.HasSequence("SEQ_EMTO_BOQ_INTER_10082018");

            modelBuilder.HasSequence("SEQ_ENT_OFFER_DETAILS");

            modelBuilder.HasSequence("SEQ_ENT_SOLUTION_STATUS");

            modelBuilder.HasSequence("SEQ_EQUIP_PRNT_DET");

            modelBuilder.HasSequence("SEQ_K2_AERIAL_FINAL");

            modelBuilder.HasSequence("SEQ_K2_AERIAL_INTER");

            modelBuilder.HasSequence("SEQ_K2_BOQ_COSUMPT_FINL_SCRIPT");

            modelBuilder.HasSequence("SEQ_K2_BOQ_DETAILS");

            modelBuilder.HasSequence("SEQ_K2_BOQ_DETAILS_11122018");

            modelBuilder.HasSequence("SEQ_K2_BOQ_DETAILS_BOQCHECK");

            modelBuilder.HasSequence("SEQ_K2_BOQ_DETAILS_ENT");

            modelBuilder.HasSequence("SEQ_K2_BOQ_DETAILS_ENT_CAPEX");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_CON_FINAL_ENT");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_CONSUMP_FINAL");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_ENT");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_INTER");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_INTER_BOQCHECK");

            modelBuilder.HasSequence("SEQ_K2_EMTO_BOQ_INTER_ENT");

            modelBuilder.HasSequence("SEQ_K2_ERROR_TABLE");

            modelBuilder.HasSequence("SEQ_K2_ERROR_TABLE_BOQCHECK");

            modelBuilder.HasSequence("SEQ_K2_ERROR_TABLE_ENT");

            modelBuilder.HasSequence("SEQ_K2_ERROR_TABLE_SCRIPT");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_CONSUMP_FINAL");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_FINAL_V2");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_FINAL_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_INT_DUM_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_INTER_DUMP_V2");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_INTER_DUMP_V2_");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_INTER_V2");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_INTER_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_V2");

            modelBuilder.HasSequence("SEQ_K2_ESTO_SOQ_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_FTTX_TABLE");

            modelBuilder.HasSequence("SEQ_K2_MATCODE_DETAILS");

            modelBuilder.HasSequence("SEQ_K2_MATCODE_DETAILS_ENT");

            modelBuilder.HasSequence("SEQ_K2_MATCODE_DETAILS_EXCLU");

            modelBuilder.HasSequence("SEQ_K2_MESTO_SOQ");

            modelBuilder.HasSequence("SEQ_K2_POP_BUSSINESS_PLANNING");

            modelBuilder.HasSequence("SEQ_K2_SERV_COD_DTL_V2_ALT_ENT");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DET_SUB_ENT");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DETA_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DETAILS");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DETAILS_SUB");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DETAILS_V2");

            modelBuilder.HasSequence("SEQ_K2_SERVICECODE_DTLS_V2_ALT");

            modelBuilder.HasSequence("SEQ_K2_SOQ_COSUMPT_FINL_SCRIPT");

            modelBuilder.HasSequence("SEQ_K2_SOQ_DETAILS");

            modelBuilder.HasSequence("SEQ_K2_SOQ_DETAILS_ENT");

            modelBuilder.HasSequence("SEQ_K2_SOQ_DETAILS_V2");

            modelBuilder.HasSequence("SEQ_K2_SOQ_DETAILS_V2_ENT");

            modelBuilder.HasSequence("SEQ_K2_SOQ_DETAILS_V2_ENT_CAPX");

            modelBuilder.HasSequence("SEQ_K2_SOQ_ERROR_TABLE");

            modelBuilder.HasSequence("SEQ_K2_SOQ_ERROR_TABLE_SCRIPT");

            modelBuilder.HasSequence("SEQ_K2_SOQ_ERROR_TABLE_V2");

            modelBuilder.HasSequence("SEQ_K2_SOQ_ERROR_TABLE_V2_ENT");

            modelBuilder.HasSequence("SEQ_MAT_DET");

            modelBuilder.HasSequence("SEQ_MOB_VERSION_USERS");

            modelBuilder.HasSequence("SEQ_O2A_WO_UPD_CANCEL_LOG");

            modelBuilder.HasSequence("SEQ_OLT_CANDIDATE");

            modelBuilder.HasSequence("SEQ_PERSON");

            modelBuilder.HasSequence("SEQ_POP_STATUS");

            modelBuilder.HasSequence("SEQ_S1S2_PROC");

            modelBuilder.HasSequence("SEQ_SCHEDULAR_ERROR_LOG");

            modelBuilder.HasSequence("SOQ_SEQ_K2_SOQ_DETAILS_V2_ENT");

            modelBuilder.HasSequence("SYNC_ID_SEQ_16548");

            modelBuilder.HasSequence("VERSION_LOG_SEQ");

            modelBuilder.HasSequence("WORK_FORCE_SEQ");

            modelBuilder.HasSequence("WRK_COMPL_SEQUENCE");
        }
    }
}
