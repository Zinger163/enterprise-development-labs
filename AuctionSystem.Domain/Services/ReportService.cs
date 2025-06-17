using System;
using System.Collections.Generic;
using System.Linq;

namespace AuctionSystem.Domain.Services
{
    public class ReportService
    {
        private readonly IBuyerRepository _buyerRepo;
        private readonly IAuctionRepository _auctionRepo;

        public ReportService(IBuyerRepository buyerRepo, IAuctionRepository auctionRepo)
        {
            _buyerRepo = buyerRepo ?? throw new ArgumentNullException(nameof(buyerRepo));
            _auctionRepo = auctionRepo ?? throw new ArgumentNullException(nameof(auctionRepo));
        }

        public List<Buyer> GetBuyersByDistrict(District district, BuildingType type)
        {
            // Инициализация пустого списка для результатов
            var resultBuyers = new List<Buyer>();

            // Получаем коллекцию аукционов (с проверкой на null)
            IEnumerable<Auction> auctions = (IEnumerable<Auction>)_auctionRepo.GetAll();
            if (auctions == null) return resultBuyers;

            // Перебираем аукционы
            foreach (var auction in auctions)
            {
                // Пропускаем null-аукционы или аукционы с null-зданиями
                if (auction == null || auction.Buildings == null) continue;

                // Перебираем здания в аукционе
                foreach (var building in auction.Buildings)
                {
                    // Пропускаем null-здания или несоответствующие критериям
                    if (building == null) continue;
                    if (building.District != district || building.Type != type) continue;
                    if (!building.BuyerId.HasValue) continue;

                    // Получаем покупателя
                    Buyer buyer = _buyerRepo.GetById(building.BuyerId.Value);

                    // Добавляем в результат если покупатель существует и еще не добавлен
                    if (buyer != null && !resultBuyers.Any(b => b.Id == buyer.Id))
                    {
                        resultBuyers.Add(buyer);
                    }
                }
            }

            // Сортируем по ФИО и возвращаем результат
            return resultBuyers.OrderBy(b => b.FullName).ToList();
        }
    }
}