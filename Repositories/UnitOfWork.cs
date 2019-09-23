using FieldOrder.DataAccessLayer.Context;
using FieldOrder.DataAccessLayer.Interfaces;
using System;

namespace FieldOrder.DataAccessLayer.Repositories
{
    public sealed class UnitOfWork
    {
        private readonly FieldOrderEntities _context;
        private bool _disposed = false;
        private IGenericDataRepository<WEC_API_EXCEPTIONS_LOG> _apiExceptionsRepo;
        private IGenericDataRepository<WEC_API_LOG> _apiLogRepo;
        private IGenericDataRepository<WEC_API_EXCEPTION_MESSAGES> _apiExceptionMessagesRepo;
        private IGenericDataRepository<WEC_CAD_ERROR_CODES> _cadErorCodesRepo;
        private IGenericDataRepository<WEC_SOAP_SERVICE_EXCEPTION_LOG> _soapServiceExceptionLogRepo;
        private IGenericDataRepository<WEC_SOAP_SERVICE_LOG> _soapServiceLogRepo;
        private IGenericDataRepository<WEC_UDF_DEFINITION> _udfDefinitionRepo;
        //private IGenericDataRepository<WEC_UDF_DEFINITION_AGENCY> _udfDefinitionAgencyRepo;
        private IGenericDataRepository<WEC_OUTBOUND_EVENT_TRIGGERS> _outboundEventTriggersRepo;
        private IGenericDataRepository<WEC_METER_INSPECTION> _meterInspectionRepo;
        private IGenericDataRepository<WEC_DNP_CUTOFF> _dnpCutoffRepo;
        private IGenericDataRepository<WEC_CREW_SKILL_MAPPING> _crewSkillMappingRepo;
        private IGenericDataRepository<WEC_API_REPORT> _reportRepo;
        private IGenericDataRepository<WEC_TOPIC_LOG> _topicLogRepo;
        private IGenericSqlDataRepository _genericSqlRepo;
        private IGenericDataRepository<WEC_BATCHJOBS> _batchJobsRepo;
        public UnitOfWork(FieldOrderEntities context)
        {
            _context = context;
        }

        public IGenericSqlDataRepository GenericSqlRepo
        {
            get
            {
                if (_genericSqlRepo == null)
                {
                    _genericSqlRepo = new GenericSqlDataRepository(_context);
                }
                return _genericSqlRepo;
            }
        }

        public IGenericDataRepository<WEC_API_EXCEPTION_MESSAGES> ApiExceptionMessagesRepo
        {
            get
            {

                if (_apiExceptionMessagesRepo == null)
                {
                    _apiExceptionMessagesRepo = new GenericDataRepository<WEC_API_EXCEPTION_MESSAGES>(_context);
                }
                return _apiExceptionMessagesRepo;
            }
        }

        public IGenericDataRepository<WEC_TOPIC_LOG> TopicLogRepo
        {
            get
            {

                if (_topicLogRepo == null)
                {
                    _topicLogRepo = new GenericDataRepository<WEC_TOPIC_LOG>(_context);
                }
                return _topicLogRepo;
            }
        }

        public IGenericDataRepository<WEC_API_EXCEPTIONS_LOG> ApiExceptionsRepo
        {
            get
            {

                if (_apiExceptionsRepo == null)
                {
                    _apiExceptionsRepo = new GenericDataRepository<WEC_API_EXCEPTIONS_LOG>(_context);
                }
                return _apiExceptionsRepo;
            }
        }

        public IGenericDataRepository<WEC_API_LOG> ApiLogRepo
        {
            get
            {

                if (_apiLogRepo == null)
                {
                    _apiLogRepo = new GenericDataRepository<WEC_API_LOG>(_context);
                }
                return _apiLogRepo;
            }
        }

        public IGenericDataRepository<WEC_CAD_ERROR_CODES> CadErorCodes
        {
            get
            {

                if (_cadErorCodesRepo == null)
                {
                    _cadErorCodesRepo = new GenericDataRepository<WEC_CAD_ERROR_CODES>(_context);
                }
                return _cadErorCodesRepo;
            }
        }

        public IGenericDataRepository<WEC_SOAP_SERVICE_EXCEPTION_LOG> SoapServiceExceptionLog
        {
            get
            {

                if (_soapServiceExceptionLogRepo == null)
                {
                    _soapServiceExceptionLogRepo = new GenericDataRepository<WEC_SOAP_SERVICE_EXCEPTION_LOG>(_context);
                }
                return _soapServiceExceptionLogRepo;
            }
        }

        public IGenericDataRepository<WEC_SOAP_SERVICE_LOG> SoapServiceLog
        {
            get
            {

                if (_soapServiceLogRepo == null)
                {
                    _soapServiceLogRepo = new GenericDataRepository<WEC_SOAP_SERVICE_LOG>(_context);
                }
                return _soapServiceLogRepo;
            }
        }

        public IGenericDataRepository<WEC_UDF_DEFINITION> UdfDefinitionRepo
        {
            get
            {

                if (_udfDefinitionRepo == null)
                {
                    _udfDefinitionRepo = new GenericDataRepository<WEC_UDF_DEFINITION>(_context);
                }
                return _udfDefinitionRepo;
            }
        }
        public IGenericDataRepository<WEC_BATCHJOBS> BatchJobsRepo
        {
            get
            {

                if (_batchJobsRepo == null)
                {
                    _batchJobsRepo = new GenericDataRepository<WEC_BATCHJOBS>(_context);
                }
                return _batchJobsRepo;
            }
        }

        //public IGenericDataRepository<WEC_UDF_DEFINITION_AGENCY> UdfDefinitionAgencyRepo
        //{
        //    get
        //    {

        //        if (_udfDefinitionAgencyRepo == null)
        //        {
        //            _udfDefinitionAgencyRepo = new GenericDataRepository<WEC_UDF_DEFINITION_AGENCY>(_context);
        //        }
        //        return _udfDefinitionAgencyRepo;
        //    }
        //}

        public IGenericDataRepository<WEC_OUTBOUND_EVENT_TRIGGERS> OutboundEventTriggersRepo
        {
            get
            {

                if (_outboundEventTriggersRepo == null)
                {
                    _outboundEventTriggersRepo = new GenericDataRepository<WEC_OUTBOUND_EVENT_TRIGGERS>(_context);
                }
                return _outboundEventTriggersRepo;
            }
        }
        public IGenericDataRepository<WEC_METER_INSPECTION> MeterInspectionRepo
        {
            get
            {

                if (_meterInspectionRepo == null)
                {
                    _meterInspectionRepo = new GenericDataRepository<WEC_METER_INSPECTION>(_context);
                }
                return _meterInspectionRepo;
            }
        }
        public IGenericDataRepository<WEC_DNP_CUTOFF> DnpCutoffRepo
        {
            get
            {

                if (_dnpCutoffRepo == null)
                {
                    _dnpCutoffRepo = new GenericDataRepository<WEC_DNP_CUTOFF>(_context);
                }
                return _dnpCutoffRepo;
            }
        }
        public IGenericDataRepository<WEC_CREW_SKILL_MAPPING> CrewSkillMappingRepo
        {
            get
            {

                if (_crewSkillMappingRepo == null)
                {
                    _crewSkillMappingRepo = new GenericDataRepository<WEC_CREW_SKILL_MAPPING>(_context);
                }
                return _crewSkillMappingRepo;
            }
        }

        public IGenericDataRepository<WEC_API_REPORT> ReportRepo
        {
            get
            {

                if (_reportRepo == null)
                {
                    _reportRepo = new GenericDataRepository<WEC_API_REPORT>(_context);
                }
                return _reportRepo;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
