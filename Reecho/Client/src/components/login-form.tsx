
import { Button } from "@/components/ui/button"
import {
    Card,
    CardContent,
} from "@/components/ui/card"
import { Input } from "@/components/ui/input"
import { Label } from "@/components/ui/label"
import {useNavigate} from "react-router";

export function LoginForm() {
    const navigate = useNavigate()
    return (
        <div className="flex flex-col gap-6">
            <Card>
                <CardContent>
                    <form>
                        <div className="grid gap-6">
                            <div className="grid gap-6">
                                <div className="grid gap-2">
                                    <Label htmlFor="email">Email</Label>
                                    <Input
                                        id="email"
                                        type="email"
                                        required
                                    />
                                </div>
                                <div className="grid gap-2">
                                    <div className="flex items-center">
                                        <Label htmlFor="password">Пароль</Label>
                                    </div>
                                    <Input id="password" type="password" required />
                                </div>
                                <Button type="submit" className="w-full">
                                    Войти
                                </Button>
                            </div>
                            <div className="text-center text-sm">
                                Нет аккаунта?{" "}
                                <a onClick={() => navigate("/register")} 
                                   className="underline underline-offset-4">
                                    Создать?
                                </a>
                            </div>
                        </div>
                    </form>
                </CardContent>
            </Card>
        </div>
    )
}
