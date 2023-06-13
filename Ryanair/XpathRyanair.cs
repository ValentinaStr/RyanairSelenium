namespace Ryanair
{
    internal static class XpathRyanair
    {
        internal const string INPUT_DEPARTURE_STATION = "//input[@id='input-button__departure']",
                              AGREE_WITH_USING_COOKIES = "//button[@data-ref='cookie.accept-all']",
                              INPUT_DESTINATION_STATION = "//input[@id='input-button__destination']",
                              INPUT_CHOOSE_DESTINATION_STATION = "//span[@data-ref='airport-item__name' and contains(text(),' ",
                              OPEN_DATE_DEPART = "//div[@data-ref='input-button__dates-from']",
                              INPUT_DATE_DEPART = "//div[@data-id='",
                              ADD_PASSENGER = "//div[@data-ref='counter.counter__increment']",
                              CONFIRM_SELECTION = "//button[@aria-label='Search']",
                              CHOICE_SELECT = "//flight-card-new[@data-ref='flight-card_all_information']",
                              CHOICE_TYPE_VALUE = "//div[@class='fare-card fare-card--primary']",
                              CHOICE_TYPE_REGULAR = "//div[@class='fare-card fare-card--secondary']",
                              CHOICE_TYPE_PLUS = "//div[@class='fare-card fare-card--tertiary']",
                              CHOICE_TYPE_FLEXI_PLUS = "//div[@class='fare-card']",
                              CHOICE_TYPE_FAMILY_PLUS = "//div[@class='fare-card fare-card--secondary-dark']",
                              CONTINUE_VALUE = "//button[@class='fare-upgrade-footer-continue_button ry-button--outline-light-blue ry-button--full']",
                              INFORMATION_ABOUT_FLIGHT = "//flights-lazy-content[@class='ng-star-inserted']",
                              BUTTON_BASKET = "//header-basket[@class='basket app-basket']",
                                                    
                              GET_ONLY_DAY_DEPART = "//div[@data-ref='outbound']//div[@class='body-m-lg body-m-sm flight-segment-details ng-star-inserted']",
                              GET_TIME_DEPART = "//div[@data-ref='outbound']//div[@class='body-m-lg body-m-sm flight-segment-details ng-star-inserted']",
							  GET_TIME_AND_CITY_DEPART_FROM = "//div[@class='flight-info__time']",
                              GET_TIME_AND_CITY_ARRIVE_TO = "//div[@data-ref='flight-segment.arrival']", 
							  GET_ONLY_DAY_RETURN = "//div[@data-ref='inbound']//div[@class='body-m-lg body-m-sm flight-segment-details ng-star-inserted']",
							  GET_TIME_AND_CITY_RETURN_FROM = "//flight-card-new[@data-e2e='flight-card--inbound']//div[@data-ref='flight-segment.departure']", 
                              GET_TIME_AND_CITY_RETURN_TO = "//flight-card-new[@data-e2e='flight-card--inbound']//div[@data-ref='flight-segment.arrival']",
							  GET_COST_GENERAL = "//ry-price-breakdown-footer[@class='footer ng-star-inserted']//ry-price[@class='price']";
    }
}


