﻿

        public Task<T> AmenityByPagination<T>(string term, string orderBy, int currentPage, string token)
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{categoryUrl}/api/v1/AmenityAPI/AmenityByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";