
import './App.css'
import { ThemeProvider } from "@/components/theme-provider"
import {Route, Routes} from "react-router";
import {MainPage} from "@/pages/main-page.tsx";
import {AdminPage} from "@/pages/admin-page.tsx";
import {NotFound} from "@/pages/not-found";
import {CardList} from "@/components/card-list.tsx";
import {useEffect, useState} from "react";
import LoginPage from "@/pages/login-page.tsx";
import RegisterPage from "@/pages/register-page.tsx";

function App() {
    const [data, setData] = useState([]);
    useEffect(() => {
        fetch("http://localhost:5000/api/vynils/all")
            .then((res) => res.json())
            .then((data) => setData(data));
    }, []);
  return (
    <>
        <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
            <Routes>
                <Route path="/" element={ <MainPage />} >
                    <Route index element={ <CardList data={data}/> }/>
                    <Route path="*" element={ <NotFound />} />
                </Route>
                <Route path="admin" element={ <AdminPage/> }/>
                <Route path="/login" element={ <LoginPage />} />
                <Route path="/register" element={ <RegisterPage /> }/>
            </Routes>
        </ThemeProvider>
    </>
  )
}

export default App
