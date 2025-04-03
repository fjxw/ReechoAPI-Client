
import {SearchHeader} from "@/components/search-header.tsx";
import {Outlet} from "react-router";


export const MainPage = () => {
    return(
        <>
            <div className="h-screen flex flex-col">
                <SearchHeader />
                <div className="flex-1">
                    <Outlet />
                </div>
            </div>
        </>
    )
}